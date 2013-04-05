using System;
using System.Drawing;
using System.Windows.Forms;
namespace Renderers
{
	public class DarkMenuStripRenderer : ToolStripRenderer
	{
		public Color colorBlack;
		public Color colorWhite;
		public Color colorDarkGray;
		public Color colorSelected;
		public Color colorSelection;
		public Color colorBorder;
		public Color colorMargin;
		public DarkMenuStripRenderer()
		{
			this.colorBlack = Color.Black;
			this.colorWhite = Color.White;
			this.colorDarkGray = Color.FromArgb(255, 26, 26, 26);
			this.colorSelected = Color.FromArgb(255, 220, 220, 220);
			//this.colorSelection = Color.FromArgb(255, 146, 180, 0);
			//this.colorSelection = Color.FromArgb(255, 204, 0, 0);
			this.colorBorder = Color.FromArgb(255, 160, 160, 160);
			this.colorMargin = Color.FromArgb(255, 160, 160, 160);
		}
		protected override void Initialize(ToolStrip toolStrip)
		{
			base.Initialize(toolStrip);
			toolStrip.ForeColor = this.colorWhite;
		}
		protected override void InitializeItem(ToolStripItem item)
		{
			base.InitializeItem(item);
			item.ForeColor = this.colorWhite;
		}
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			SolidBrush brush = new SolidBrush(this.colorDarkGray);
			e.Graphics.FillRectangle(brush, e.AffectedBounds);
		}
		protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
		{
			base.OnRenderImageMargin(e);
			SolidBrush brush = new SolidBrush(this.colorSelected);
			Rectangle rect = new Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
			e.Graphics.FillRectangle(brush, rect);
		}
		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
		{
			base.OnRenderItemCheck(e);
			bool selected = e.Item.Selected;
			if (selected)
			{
				Rectangle rect = new Rectangle(4, 2, 18, 18);
				SolidBrush brush = new SolidBrush(this.colorSelected);
				e.Graphics.FillRectangle(brush, rect);
				Graphics arg_5A_0 = e.Graphics;
				Image arg_5A_1 = e.Image;
				Point point = new Point(5, 3);
				arg_5A_0.DrawImage(arg_5A_1, point);
			}
			else
			{
				selected = e.Item.Selected;
				if (selected)
				{
					Rectangle rect2 = new Rectangle(4, 2, 18, 18);
					SolidBrush brush2 = new SolidBrush(this.colorSelected);
					e.Graphics.FillRectangle(brush2, rect2);
					Graphics arg_B3_0 = e.Graphics;
					Image arg_B3_1 = e.Image;
					Point point = new Point(5, 3);
					arg_B3_0.DrawImage(arg_B3_1, point);
				}
			}
		}
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			base.OnRenderSeparator(e);
			SolidBrush brush = new SolidBrush(this.colorMargin);
			SolidBrush brush2 = new SolidBrush(this.colorWhite);
			checked
			{
				Rectangle rect = new Rectangle(32, 3, e.Item.Width - 32, 1);
				Rectangle rect2 = new Rectangle(32, 4, e.Item.Width - 32, 1);
				e.Graphics.FillRectangle(brush, rect);
				e.Graphics.FillRectangle(brush2, rect2);
			}
		}
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
			base.OnRenderArrow(e);
			bool enabled = e.Item.Enabled;
			checked
			{
				if (enabled)
				{
					bool flag = !e.Item.IsOnDropDown && e.Item.Selected;
					if (flag)
					{
						Rectangle rect = new Rectangle(3, 0, e.Item.Width - 6, e.Item.Height);
						SolidBrush brush = new SolidBrush(this.colorSelected);
						e.Graphics.FillRectangle(brush, rect);
						e.Item.ForeColor = this.colorBlack;
					}
					else
					{
						flag = (e.Item.IsOnDropDown && e.Item.Selected);
						if (flag)
						{
							Rectangle rect2 = new Rectangle(3, 0, e.Item.Width - 6, e.Item.Height);
							SolidBrush brush2 = new SolidBrush(this.colorSelection);
							e.Graphics.FillRectangle(brush2, rect2);
							e.Item.ForeColor = this.colorBlack;
						}
						else
						{
							flag = (!e.Item.IsOnDropDown && !e.Item.Selected);
							if (flag)
							{
								e.Item.ForeColor = this.colorWhite;
							}
						}
					}
					flag = (((ToolStripMenuItem)e.Item).DropDown.Visible && !e.Item.IsOnDropDown);
					if (flag)
					{
						Rectangle rect3 = new Rectangle(3, 0, e.Item.Width - 6, e.Item.Height);
						SolidBrush brush3 = new SolidBrush(this.colorSelected);
						e.Graphics.FillRectangle(brush3, rect3);
						e.Item.ForeColor = this.colorBlack;
					}
				}
			}
		}
	}
}
