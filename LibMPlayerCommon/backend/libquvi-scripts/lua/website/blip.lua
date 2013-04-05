
-- libquvi-scripts
-- Copyright (C) 2011-2012  Toni Gundogdu <legatvs@gmail.com>
--
-- This file is part of libquvi-scripts <http://quvi.sourceforge.net/>.
--
-- This library is free software; you can redistribute it and/or
-- modify it under the terms of the GNU Lesser General Public
-- License as published by the Free Software Foundation; either
-- version 2.1 of the License, or (at your option) any later version.
--
-- This library is distributed in the hope that it will be useful,
-- but WITHOUT ANY WARRANTY; without even the implied warranty of
-- MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
-- Lesser General Public License for more details.
--
-- You should have received a copy of the GNU Lesser General Public
-- License along with this library; if not, write to the Free Software
-- Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA
-- 02110-1301  USA
--

-- Based on get-flash-videos' Blip.pm
-- <https://github.com/monsieurvideo/get-flash-videos/>

local Blip = {} -- Utility functions unique to this script.

-- Identify the script.
function ident(self)
    package.path = self.script_dir .. '/?.lua'
    local C      = require 'quvi/const'
    local r      = {}
    r.domain     = "blip%.tv"
    r.formats    = "default|best"
    r.categories = C.proto_http
    local U      = require 'quvi/util'
    r.handles    = U.handles(self.page_url, {r.domain},
                    -- Paths: Room for improvement.
                    {"/file/%d+",
                     "/play/%w+",
                     "/flash/%d+",
                     "/scripts/flash/",
                     "%-%d+"})
    return r
end

-- Query formats.
function query_formats(self)
    local c = Blip.get_config(self)
    local formats = Blip.iter_formats(c)

    local t = {}
    for _,v in pairs(formats) do
        table.insert(t, Blip.to_s(v))
    end

    table.sort(t)
    self.formats = table.concat(t, "|")

    return self
end

-- Parse media URL.
function parse(self)
    self.host_id = "blip"

    local c,U = Blip.get_config(self)

    self.title = c:match('media:title>(.-)</')
                  or error('no match: media title')

    self.thumbnail_url = c:match('<blip:smallThumbnail>(.-)<') or ''

    local formats = Blip.iter_formats(c)
    local format  = U.choose_format(self, formats,
                                     Blip.choose_best,
                                     Blip.choose_default,
                                     Blip.to_s)
                        or error("unable to choose format")
    self.url      = {format.url or error("no match: media URL")}
    return self
end

--
-- Utility functions
--

function Blip.get_config(self)
    local U       = require 'quvi/util'
    self.page_url = U.unescape(self.page_url)

    local id = self.page_url:match('/flash/(%d+)')
    if not id then
        local r = quvi.resolve(self.page_url)
        if #r > 0 then
            r = U.unescape(r)
            id = r:match('/rss/flash/(%d+)')
        end
    end

    if not id then
        local p = quvi.fetch(self.page_url)
        id = p:match('data%-posts%-id="(.-)"')
    end
    self.id = id or error('no match: media ID')

    local c_url = 'http://blip.tv/rss/flash/' .. self.id

    return quvi.fetch(c_url, {fetch_type='config'}), U
end

function Blip.iter_formats(c)
    local p = '<media:content url="(.-)"'
           .. '.-blip:role="(.-)"'
           .. '.-height="(.-)"'
           .. '.-isDefault="(.-)"'
           .. '.-width="(.-)"'
    local t = {}
    for u,r,h,d,w in c:gmatch(p) do
        r = string.lower(r)
        r = r:gsub(' ','_')
        r = r:gsub('[()]','')
        w = (w ~= nil) and tonumber(w) or 0 -- Some media do not have 'width'
        h = (h ~= nil) and tonumber(h) or 0 -- or 'height', e.g. audio
        local s = u:match('%.(%w+)$')
        table.insert(t, {width=w, height=h, url=u, default=d,
                         role=r,  container=s})
    end
    return t
end

function Blip.choose_best(formats) -- Highest quality available
    local r = {width=0, height=0, url=nil}
    local U = require 'quvi/util'
    for _,v in pairs(formats) do
        if U.is_higher_quality(v,r) then
            r = v
        end
    end
--    for k,v in pairs(r) do print(k,v) end
    return r
end

function Blip.choose_default(formats) -- Website sets this flag, reuse it.
    for _,v in pairs(formats) do
        if v.default == 'true' then
--            for k,_v in pairs(v) do print(k,_v) end
            return v
        end
    end
    error('no match: default')
end

function Blip.to_s(t)
    return (t.height > 0)
        and string.format("%s_%s_%sp", t.container, t.role, t.height)
        or  string.format("%s_%s", t.container, t.role)
end

-- vim: set ts=4 sw=4 tw=72 expandtab:
