using System;
public class Amazing
{
	static int target = 0;      // where GOTO goes
	public static Random random = new Random(0);
	public static string result = "";
    private static int[,] _resolvedCoordinates;
    private static int _resolvedCoordinateCount;

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

	public static void doit(int horizontalLimit, int verticalLimit) 
	{
		clear();
		print("Amazing - Copyright by Creative Computing, Morristown, NJ");
		println();
        
	    if (horizontalLimit == 1 || verticalLimit == 1) return;

        // TODO Confirm that this array is used to record resolved coordinates
		_resolvedCoordinates = new int[horizontalLimit + 1,verticalLimit + 1];
		
        // TODO Confirm that this array is used to build the printable array
		int[,] vArray = new int[horizontalLimit + 1,verticalLimit + 1];
		
        // TODO What is this variable for?
		int q = 0;

        // TODO What is this variable for?
		int z = 0;

		int x = RandomIntFrom0To(horizontalLimit);

		PrintTopRow(horizontalLimit, x);

        // 190
        // TODO Confirm the following
        // Is incremented for each resolved coordinate
        // Vaue is assigned to resolvedCoordinates to mark resolved coordinate
        _resolvedCoordinateCount = 1;
        SetResolvedCoordinateCount(x, 1);
        _resolvedCoordinateCount++;

		// 200
		int currentColumn = x;
		int currentRow = 1;
		GOTO(270);

		while (target != -1) 
		{
			switch (target) 
			{
				case 210:
					if (currentColumn != horizontalLimit)
					{
					    currentColumn++;
                    }
					else
					{
					    if (currentRow != verticalLimit)
					    {
					        currentColumn = 1;
					        currentRow++;
                        }
					    else
					    {
					        currentColumn = 1;
					        currentRow = 1;
                        }
                    }
				    GOTO(260);
                    continue;
				case 260:
					if (_resolvedCoordinates[currentColumn,currentRow] == 0)
					{
					    GOTO(210);
					}
					else
					{
					    GOTO(270);
					}
					continue;

                // TODO Extract method for this case
				case 270:
                    // TODO I think this condition is: if west is blocked
					if (WestIsUnavailable(currentColumn, _resolvedCoordinates, currentRow))
					{
					    GOTO(600);
					}
					else
					{
                        // TODO I think this condition is: if north is blocked
					    if (NorthIsUnavailable(currentRow, _resolvedCoordinates, currentColumn))
					    {
					        GOTO(430);
					    }
					    else
					    {
                            // TODO I think this condition is: if east is blocked
					        if (EastIsUnavailable(horizontalLimit, currentColumn, _resolvedCoordinates, currentRow))
					        {
					            if ((currentRow != verticalLimit))
					            {
					                if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					                {
					                    GOTO(410);
					                }
					                else
					                {
					                    GOTO(390);
					                }
					            }
					            else
					            {
					                if (z == 1)
					                {
					                    GOTO(410);
					                }
					                else
					                {
					                    q = 1;
					                    GOTO(390);
					                }
					            }
                            }
					        else
                            {
                                x = RandomIntFrom0To(3);
                                if (x == 1)
                                {
                                    GOTO(940);
                                }
                                else if (x == 2)
                                {
                                    GOTO(980);
                                }
                                else if (x == 3)
                                {
                                    GOTO(1020);
                                }
                            }
                        }
                    }
					continue;
                    
				case 390:
					x = RandomIntFrom0To(3);
					if (x == 1)
					{
					    GOTO(940);
					}
					else if (x == 2)
					{
					    GOTO(980);
					}
					else if (x == 3)
					{
					    GOTO(1090);
					}
					continue;
				case 410:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(980);
					continue;

                // TODO Another core method?
				case 430:
					if ((currentColumn == horizontalLimit) || (_resolvedCoordinates[currentColumn + 1, currentRow] != 0))
					{
					    if (currentRow != verticalLimit)
					    {
					        if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					        {
					            GOTO(940);
					        }
					        else
					        {
					            GOTO(570);
					        }
                        }
					    else
					    {
					        if (z == 1)
					        {
					            GOTO(940);
					        }
					        else
					        {
					            q = 1;
					            GOTO(570);
                            }
                        }
                    }
					else
					{
					    if (currentRow != verticalLimit)
					    {
					        if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					        {
					            GOTO(510);
					        }
					        else
					        {
					            GOTO(490);
					        }
                        }
					    else
					    {
					        if (z == 1)
					        {
					            GOTO(510);
					        }
					        else
					        {
					            q = 1;
					            GOTO(490);
                            }
                        }
                    }
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

				case 570:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(940);
					else if (x == 2)
						GOTO(1090);
					continue;

                // TODO Another core method?
				case 600:
					if ((currentRow - 1 == 0) || (_resolvedCoordinates[currentColumn, currentRow - 1] != 0))
					{
					    if ((currentColumn == horizontalLimit) || (_resolvedCoordinates[currentColumn + 1, currentRow] != 0))
					    {
					        if (currentRow != verticalLimit)
					        {
					            if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					            {
					                GOTO(210);
					            }
					            else
					            {
					                GOTO(1090);
					            }
					        }
					        else
					        {
					            if (z == 1)
					            {
					                GOTO(210);
					            }
					            else
					            {
					                q = 1;
					                GOTO(1090);
					            }
					        }
					    }
					    else
					    {
					        if (currentRow != verticalLimit)
					        {
					            if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					            {
					                GOTO(1020);
					            }
					            else
					            {
					                x = RandomIntFrom0To(2);
					                if (x == 1)
					                {
					                    GOTO(1020);
					                }
					                else if (x == 2)
					                {
					                    GOTO(1090);
					                }
					            }
					        }
					        else
					        {
					            if (z == 1)
					            {
					                GOTO(1020);
					            }
					            else
					            {
					                q = 1;
					                GOTO(990);
					            }
					        }
					    }
                    }
					else
					{
					    if ((currentColumn == horizontalLimit) || (_resolvedCoordinates[currentColumn + 1, currentRow] != 0))
					    {
					        if (currentRow != verticalLimit)
					        {
					            if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					            {
					                GOTO(980);
					            }
					            else
					            {
					                GOTO(760);
					            }
                            }
					        else
					        {
					            if (z == 1)
					            {
					                GOTO(980);
					            }
					            else
					            {
					                q = 1;
					                GOTO(760);
                                }
                            }
                        }
					    else
					    {
					        if(currentRow != verticalLimit)
					        {
					            if (_resolvedCoordinates[currentColumn, currentRow + 1] != 0)
					            {
					                GOTO(700);
					            }
					            else
					            {
					                GOTO(680);
					            }
                            }
					        else
					        {
					            if (z == 1)
					            {
					                GOTO(700);
					            }
					            else
					            {
					                q = 1;
					                GOTO(680);
                                }
                            }
                        }
                    }
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

				case 760:
					x = RandomIntFrom0To(2);
					if (x == 1)
						GOTO(980);
					else if (x == 2)
						GOTO(1090);
					continue;

                // TODO Another core method?
                case 940:
                    SetResolvedCoordinateCount(currentColumn - 1, currentRow);
                    _resolvedCoordinateCount++;
                    vArray[currentColumn - 1, currentRow] = 2;
                    currentColumn--;
                    if (MazeIsComplete(horizontalLimit, verticalLimit))
                    {
                        GOTO(1200);
                    }
                    else
                    {
                        q = 0;
                        GOTO(270);
                    }
                    continue;

			    // TODO Another core method?
                case 980:
                    SetResolvedCoordinateCount(currentColumn, currentRow - 1);
					GOTO(990);
					continue;

				case 990:
				    _resolvedCoordinateCount++;
                    GOTO(1000);
					continue;
				case 1000:
					vArray[currentColumn,currentRow - 1] = 1;
					currentRow--;
					if (MazeIsComplete(horizontalLimit, verticalLimit))
					{
					    GOTO(1200);
					}
					else
					{
					    q = 0;
					    GOTO(270);
                    }
					continue;


                // TODO Another core method?
                case 1020:
                    SetResolvedCoordinateCount(currentColumn + 1, currentRow);
                    _resolvedCoordinateCount++;
                    if (vArray[currentColumn,currentRow] == 0)
                    {
                        vArray[currentColumn, currentRow] = 2;
                    }
					else
                    {
                        vArray[currentColumn, currentRow] = 3;
                    }
					currentColumn++;
					if (MazeIsComplete(horizontalLimit, verticalLimit))
					{
					    GOTO(1200);
					}
					else
					{
					    GOTO(600);
					}
					continue;

				case 1090:
					if (q == 1)
						GOTO(1150);
					else
						GOTO(1100);
					continue;
				case 1100:
                    SetResolvedCoordinateCount(currentColumn, currentRow + 1);
				    _resolvedCoordinateCount++;
                    if (vArray[currentColumn,currentRow] == 0)
						GOTO(1120);
					else
					{
					    vArray[currentColumn, currentRow] = 3;
					    GOTO(1130);
                    }
					continue;
				case 1120:
					vArray[currentColumn,currentRow] = 1;
					GOTO(1130);
					continue;
				case 1130:
					if (MazeIsComplete(horizontalLimit, verticalLimit))
						GOTO(1200);
					else
					{
					    currentRow++;
					    GOTO(270);
					}
					continue;
				case 1150:
					z = 1;
				    if (vArray[currentColumn, currentRow] == 0)
				        GOTO(1180);
				    else
				        GOTO(1170);
                    continue;
				case 1170:
					vArray[currentColumn,currentRow] = 3;
					q = 0;
					GOTO(210);
					continue;
				case 1180:
					vArray[currentColumn,currentRow] = 1;
					q = 0;
					currentColumn = 1;
					currentRow = 1;
					GOTO(260);
					continue;
				case 1200:
					target = -1;
					continue;
			}

		}

		ConstructMazeFrom(verticalLimit, horizontalLimit, vArray);
	}

    private static void SetResolvedCoordinateCount(int column, int row)
    {
        //_resolvedCoordinateCount++;
        _resolvedCoordinates[column, row] = _resolvedCoordinateCount;
    }

    private static bool EastIsUnavailable(int horizontalLimit, int currentColumn, int[,] resolvedCoordinates, int currentRow)
    {
        return (currentColumn == horizontalLimit) || (resolvedCoordinates[currentColumn + 1, currentRow] != 0);
    }

    private static bool NorthIsUnavailable(int currentRow, int[,] resolvedCoordinates, int currentColumn)
    {
        return (currentRow - 1 == 0) || (resolvedCoordinates[currentColumn, currentRow - 1] != 0);
    }

    private static bool WestIsUnavailable(int currentColumn, int[,] resolvedCoordinates, int currentRow)
    {
        return (currentColumn - 1 == 0) || (resolvedCoordinates[currentColumn - 1, currentRow] != 0);
    }

    private static bool MazeIsComplete(int h, int v)
    {
        return _resolvedCoordinateCount == h * v + 1;
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
