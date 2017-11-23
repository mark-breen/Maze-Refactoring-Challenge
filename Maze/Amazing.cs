using System;
public class Amazing
{
	static int target = 0;      // where GOTO goes
	public static Random random = new Random(0);
	public static string result = "";

	public static void main(String[] args) 
	{
		doit(int.Parse(args[0]),int.Parse(args[1]));
		System.Console.WriteLine(result);
	}

	private static void clear() 
	{
		result = "";
	}

	private static void println() 
	{
		result += "\r\n";
	}

	public static void print(String text) 
	{
		result += text;
	}

	public static int RandomIntFrom0To(int count) 
	{
		return (int) (count * random.NextDouble()) + 1;
	}

	public static void GOTO(int lineno) 
	{
		target = lineno;
	}

	public static void doit(int horizontal, int vertical) 
	{
		clear();
		print("Amazing - Copyright by Creative Computing, Morristown, NJ");
		println();

		int h = horizontal;
		int v = vertical;
		if (h == 1 || v == 1) return;

		int[,] wArray = new int[h + 1,v + 1];
		

		int[,] vArray = new int[h + 1,v + 1];
		

		int q = 0;
		int z = 0;
		int x = RandomIntFrom0To(h);

		PrintTopRow(h, x);

	    // 190
		int c = 1;
		wArray[x,1] = c;
		c++;

		// 200
		int r = x;
		int s = 1;
		GOTO(270);

		while (target != -1) 
		{
			switch (target) 
			{
				case 210:
					if (r != h)
					{
					    r++;
                    }
					else
					{
					    if (s != v)
					    {
					        r = 1;
					        s++;
                        }
					    else
					    {
					        r = 1;
					        s = 1;
                        }
                    }
				    GOTO(260);
                    continue;
				case 260:
					if (wArray[r,s] == 0)
						GOTO(210);
					else
						GOTO(270);
					continue;

                // TODO Extract method for this case
				case 270:
					if (r - 1 == 0)
						GOTO(600);
					else
					{
					    if (wArray[r - 1, s] != 0)
					        GOTO(600);
					    else
					    {
					        if (s - 1 == 0)
					            GOTO(430);
					        else
					        {
					            if (wArray[r, s - 1] != 0)
					                GOTO(430);
					            else
					            {
					                if (r == h)
					                    GOTO(350);
					                else
					                    GOTO(320);
                                }
                            }
                        }
                    }
					continue;
				case 320:
					if (wArray[r + 1,s] != 0)
						GOTO(350);
					else
						GOTO(330);
					continue;
				case 330:
					x = RandomIntFrom0To(3);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(980);
					else if (x == 3)
						GOTO(1020);
					continue;
				case 350:
					if (s != v)
						GOTO(380);
					else
						GOTO(360);
					continue;
				case 360:
					if (z == 1)
						GOTO(410);
					else
						GOTO(370);
					continue;
				case 370:
					q = 1;
					GOTO(390);
					continue;
				case 380:
					if (wArray[r,s + 1] != 0)
						GOTO(410);
					else
						GOTO(390);
					continue;
				case 390:
					x = RandomIntFrom0To(3);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(980);
					else if (x == 3)
						GOTO(1090);
					continue;
				case 410:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(980);
					continue;
				case 430:
					if (r == h)
						GOTO(530);
					else
						GOTO(440);
					continue;
				case 440:
					if (wArray[r + 1,s] != 0)
						GOTO(530);
					else
						GOTO(450);
					continue;
				case 450:
					if (s != v)
						GOTO(480);
					else
						GOTO(460);
					continue;
				case 460:
					if (z == 1)
						GOTO(510);
					else
						GOTO(470);
					continue;
				case 470:
					q = 1;
					GOTO(490);
					continue;
				case 480:
					if (wArray[r,s + 1] != 0)
						GOTO(510);
					else
						GOTO(490);
					continue;
				case 490:
					x = RandomIntFrom0To(3);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(1020);
					else if (x == 3)
						GOTO(1090);
					continue;
				case 510:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(1020);
					continue;
				case 530:
					if (s != v)
						GOTO(560);
					else
						GOTO(540);
					continue;
				case 540:
					if (z == 1)
						GOTO(940);
					else
						GOTO(550);
					continue;
				case 550:
					q = 1;
					GOTO(570);
					continue;
				case 560:
					if (wArray[r,s + 1] != 0)
						GOTO(940);
					else
						GOTO(570);
					continue;
				case 570:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(1090);
					continue;
				case 600:
					if (s - 1 == 0)
						GOTO(790);
					else
						GOTO(610);
					continue;
				case 610:
					if (wArray[r,s - 1] != 0)
						GOTO(790);
					else
						GOTO(620);
					continue;
				case 620:
					if (r == h)
						GOTO(720);
					else
						GOTO(630);
					continue;
				case 630:
					if (wArray[r + 1,s] != 0)
						GOTO(720);
					else
						GOTO(640);
					continue;
				case 640:
					if (s != v)
						GOTO(670);
					else
						GOTO(650);
					continue;
				case 650:
					if (z == 1)
						GOTO(700);
					else
						GOTO(660);
					continue;
				case 660:
					q = 1;
					GOTO(680);
					continue;
				case 670:
					if (wArray[r,s + 1] != 0)
						GOTO(700);
					else
						GOTO(680);
					continue;
				case 680:
					x = RandomIntFrom0To(3);
					if (x == 1)
						GOTO(980);
					else if (x == 2)
						GOTO(1020);
					else if (x == 3)
						GOTO(1090);
					continue;
				case 700:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(980);
					else if (x == 2)
						GOTO(1020);
					continue;
				case 720:
					if (s != v)
						GOTO(750);
					else
						GOTO(730);
					continue;
				case 730:
					if (z == 1)
						GOTO(980);
					else
						GOTO(740);
					continue;
				case 740:
					q = 1;
					GOTO(760);
					continue;
				case 750:
					if (wArray[r,s + 1] != 0)
						GOTO(980);
					else
						GOTO(760);
					continue;
				case 760:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(980);
					else if (x == 2)
						GOTO(1090);
					continue;
				case 790:
					if (r == h)
						GOTO(880);
					else
						GOTO(800);
					continue;
				case 800:
					if (wArray[r + 1,s] != 0)
						GOTO(880);
					else
						GOTO(810);
					continue;
				case 810:
					if (s != v)
						GOTO(840);
					else
						GOTO(820);
					continue;
				case 820:
					if (z == 1)
						GOTO(1020);
					else
						GOTO(830);
					continue;
				case 830:
					q = 1;
					GOTO(990);
					continue;
				case 840:
					if (wArray[r,s + 1] != 0)
						GOTO(1020);
					else
						GOTO(850);
					continue;
				case 850:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(1020);
					else if (x == 2)
						GOTO(1090);
					continue;
				case 880:
					if (s != v)
						GOTO(910);
					else
						GOTO(890);
					continue;
				case 890:
					if (z == 1)
						GOTO(210);
					else
						GOTO(900);
					continue;
				case 900:
					q = 1;
					GOTO(1090);
					continue;
				case 910:
					if (wArray[r,s + 1] != 0)
						GOTO(210);
					else
						GOTO(1090);
					continue;
				case 940:
					wArray[r - 1,s] = c;
					GOTO(950);
					continue;
				case 950:
					c++;
					vArray[r - 1,s] = 2;
					r--;
					GOTO(960);
					continue;
				case 960:
					if (MazeIsComplete(c, h, v))
						GOTO(1200);
					else
					{
					    q = 0;
					    GOTO(270);
                    }
					continue;
				case 980:
					wArray[r,s - 1] = c;
					GOTO(990);
					continue;
				case 990:
					c++;
					GOTO(1000);
					continue;
				case 1000:
					vArray[r,s - 1] = 1;
					s--;
					if (MazeIsComplete(c, h, v))
						GOTO(1200);
					else
					{
					    q = 0;
					    GOTO(270);
                    }
					continue;
				case 1020:
					wArray[r + 1,s] = c;
					c++;
					if (vArray[r,s] == 0)
						GOTO(1050);
					else
						GOTO(1040);
					continue;
				case 1040:
					vArray[r,s] = 3;
					GOTO(1060);
					continue;
				case 1050:
					vArray[r,s] = 2;
					GOTO(1060);
					continue;
				case 1060:
					r++;
					GOTO(1070);
					continue;
				case 1070:
					if (MazeIsComplete(c, h, v))
						GOTO(1200);
					else
						GOTO(600);
					continue;
				case 1090:
					if (q == 1)
						GOTO(1150);
					else
						GOTO(1100);
					continue;
				case 1100:
					wArray[r,s + 1] = c;
					c++;
					if (vArray[r,s] == 0)
						GOTO(1120);
					else
					{
					    vArray[r, s] = 3;
					    GOTO(1130);
                    }
					continue;
				case 1120:
					vArray[r,s] = 1;
					GOTO(1130);
					continue;
				case 1130:
					if (MazeIsComplete(c, h, v))
						GOTO(1200);
					else
					{
					    s++;
					    GOTO(270);
					}
					continue;
				case 1150:
					z = 1;
				    if (vArray[r, s] == 0)
				        GOTO(1180);
				    else
				        GOTO(1170);
                    continue;
				case 1170:
					vArray[r,s] = 3;
					q = 0;
					GOTO(210);
					continue;
				case 1180:
					vArray[r,s] = 1;
					q = 0;
					r = 1;
					s = 1;
					GOTO(260);
					continue;
				case 1200:
					target = -1;
					continue;
			}

		}

		ConstructMazeFrom(v, h, vArray);
	}

    private static bool MazeIsComplete(int c, int h, int v)
    {
        return c == h * v + 1;
    }

    private static void ConstructMazeFrom(int v, int h, int[,] vArray)
    {
// 1200:
        for (int j = 1; j <= v; j++)
        {
            PrintVerticalWalls(h, vArray, j);

            PrintHorizontalWalls(h, vArray, j);
        }
    }


    private static void PrintHorizontalWalls(int h, int[,] vArray, int j)
    {
        for (int i = 1; i <= h; i++)
        {
            if (vArray[i, j] == 0)
                print(":--"); // 1300, 1340
            else if (vArray[i, j] == 2)
                print(":--"); // 1310, 1340
            else
                print(":  "); // 1320
        }

        print(":"); // 1360
        println();
    }

    private static void PrintVerticalWalls(int h, int[,] vArray, int j)
    {
        print("I"); // 1210

        for (int i = 1; i <= h; i++)
        {
            if (vArray[i, j] >= 2)
                print("   "); // 1240
            else
                print("  I"); // 1260
        }

        print(" "); // 1280
        println();
    }

    private static void PrintTopRow(int h, int x)
    {
        // 130:170
        for (int i = 1; i <= h; i++)
        {
            if (i == x)
                print(":  ");
            else
                print(":--");
        }
        // 180
        print(":");
        println();
    }
}
