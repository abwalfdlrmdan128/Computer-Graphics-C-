using System;
using System.Drawing;

public static class DDA
{
	public static void DrawLine(Graphics g, int x1, int y1, int x2, int y2, Color color)
	{
		int dx = x2 - x1;
		int dy = y2 - y1;

		int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

		float xInc = dx / (float)steps;
		float yInc = dy / (float)steps;

		float x = x1;
		float y = y1;

		for (int i = 0; i <= steps; i++)
		{
			g.FillRectangle(new SolidBrush(color), (int)x, (int)y, 2, 2);
			x += xInc;
			y += yInc;
		}
	}
}
