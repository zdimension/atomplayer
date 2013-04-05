
-- libquvi-scripts
-- Copyright (C) 2011  Toni Gundogdu <legatvs@gmail.com>
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

-- NOTE: pluzz.fr videos expire 7 days after their original broadcast
-- on France Televisions

-- Identify the script.
function ident(self)
    package.path = self.script_dir .. '/?.lua'
    local C      = require 'quvi/const'
    local r      = {}
    r.domain     = "pluzz%.fr"
    r.formats    = "default"
    r.categories = C.proto_mms
    local U      = require 'quvi/util'
    r.handles    = U.handles(self.page_url, {r.domain}, {"/.-%.html"})
    return r
end

-- Query available formats.
function query_formats(self)
    self.formats = 'default'
    return self
end

-- Parse media URL.
function parse(self)
    local page = quvi.fetch(self.page_url)

    local s = page:match('class="alert">(.-)<')
    if s then
        local H = require 'quvi/html'
        error(s:gsub('&#(%d+);', H.to_utf8))
    end

    self.redirect_url = page:match('<div id="playerCtnr">.-<a href="(.-)"')
                            or error("no match: redirect url")

    return self
end

-- vim: set ts=4 sw=4 tw=72 expandtab:
