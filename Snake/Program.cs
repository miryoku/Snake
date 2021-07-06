using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int origWidth, origHeight;
             origWidth = Console.WindowWidth;
             origHeight = Console.WindowHeight;
             GameOver(origWidth, origHeight);
             /* Console.WindowHeight = 50;
              Console.WindowWidth = 150;*/
            Console.CursorVisible=false;
            Menu();



        }
        public static void Menu()
        {
            Console.Clear();
            int origWidth, origHeight;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            Title((origWidth / 4) - 4, (origHeight / 4) - 5);
            Option((origWidth / 2) - 4, (origHeight / 2));
            int nombreMenu = 3;
            int i = Nav(nombreMenu, origWidth, origHeight);
            SwitchChoice(i, origWidth, origHeight);
        }

        private static int Nav(int nb, int Witdth, int height)
        {
            ConsoleKeyInfo cki;
            int i = 0, oldWidth = 0;
            do
            {
                Design((Witdth / 2) - 4, (height / 2) + (i * 2), oldWidth);
                cki = Console.ReadKey();

                oldWidth = (height / 2) + (i * 2);
                if (cki.Key == ConsoleKey.DownArrow)
                {

                    i++;
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {

                    i--;

                }
                if (i >= nb)
                {
                    i = 0;
                }
                else if (i < 0)
                {
                    i = nb - 1;
                }
            } while (cki.Key != ConsoleKey.Enter);

            return i;
        }


        private static void Title(int width, int height)
        {
            string[] name = new string[6];
            name[0] = "    _                _             ______  _           _     ";
            name[1] = "   | |              | |           (____  \\(_)_        | |    ";
            name[2] = "    \\ \\  ____   ____| |  _ ____    ____)  )_| |_  ____| | _  ";
            name[3] = "     \\ \\|  _ \\ / _  | | / ) _  )  |  __  (| |  _)/ ___) || \\ ";
            name[4] = " _____) ) | | ( ( | | |< ( (/ /   | |__)  ) | |_( (___| | | |";
            name[5] = "(______/|_| |_|\\_||_|_| \\_)____)  |______/|_|\\___)____)_| |_|";


            for (int i = 0; i < name.Length; i++)
            {
                Console.SetCursorPosition(width, height + i);
                Console.WriteLine(name[i]);
            }

        }

        private static void Option(int width, int height)
        {
            Console.SetCursorPosition(width, height);
            Console.WriteLine("Joue");
            Console.SetCursorPosition(width, height + 2);
            Console.WriteLine("Option");
            Console.SetCursorPosition(width, height + 4);
            Console.WriteLine("Quitte");
        }

        private static void Design(int width, int height, int old)
        {
            Console.SetCursorPosition(width - 5, old);
            Console.WriteLine(" ");
            Console.SetCursorPosition(width + 8, old);
            Console.WriteLine(" ");
            Console.SetCursorPosition(width - 5, height);
            Console.WriteLine("[");
            Console.SetCursorPosition(width + 8, height);
            Console.WriteLine("]");
        }

        private static void SwitchChoice(int i, int origWidth, int oriHeight)
        {
            Console.SetCursorPosition(0, 0);
            switch (i)
            {
                case 0:
                    Play(ModeDifficulty(origWidth, oriHeight));
                    Menu();
                    break;
                case 1:

                    AfficheOption(origWidth/10, oriHeight/10);
                    Console.ReadKey();
                    Play(ModeDifficulty(origWidth, oriHeight));
                    break;
                case 2:
                    Exit(origWidth, oriHeight);
                    break;
            }
        }

        private static int ModeDifficulty(int width, int height)
        {

            Console.Clear();

            string[] name = new string[4];
            name[0] = " __        __     __       ___          __     ___  ___    __            ___  ___     __            __             __  ";
            name[1] = "/  ` |__| /  \\ | /__` |     |   /\\     |  \\ | |__  |__  | /  ` |  | |     |  |__     |__)  /\\  \\ / /__`  /\\  |\\ | /__` ";
            name[2] = "\\__, |  | \\__/ | .__/ |     |  /~~\\    |__/ | |    |    | \\__, \\__/ |___  |  |___    |    /~~\\  |  .__/ /~~\\ | \\| .__/ ";
            name[3] = "                                                                                                                       ";
            for (int i = 0; i < name.Length; i++)
            {
                Console.SetCursorPosition(1, (height / 4) + i);
                Console.WriteLine(name[i]);
            }
            Console.SetCursorPosition((width / 2) - 5, height / 2);
            Console.WriteLine("easy");
            Console.SetCursorPosition((width / 2) - 5, (height / 2) + 2);
            Console.WriteLine("normal");
            Console.SetCursorPosition((width / 2) - 5, (height / 2) + 4);
            Console.WriteLine("difficile");
            Console.SetCursorPosition((width / 2) - 5, (height / 2) + 6);
            Console.WriteLine("extreme ");

            int val = Nav(4, width, height);
            return ((5 - val - 1) * 100) / 2;
        }

        private static void Exit(int width, int height)
        {
            Console.Clear();

            string[] name = new string[9];

            name[0] = " ______     __         ____                             ___             ";
            name[1] = "/\\  _  \\   /\\ \\       /\\  _`\\                       __ /\\_ \\            ";
            name[2] = "\\ \\ \\L\\ \\  \\_\\ \\___   \\ \\ \\L\\_\\_ __    __       __ /\\_\\//\\ \\      __   ";
            name[3] = " \\ \\  __ \\/\\___  __\\   \\ \\  _\\/\\`'__\\/'__`\\   /'_ `\\/\\ \\ \\ \\ \\   /'__`\\ ";
            name[4] = "  \\ \\ \\/\\ \\/__/\\ \\_/    \\ \\ \\/\\ \\ \\//\\ \\L\\.\\_/\\ \\L\\ \\ \\ \\ \\_\\ \\_/\\  __/ ";
            name[5] = "   \\ \\_\\ \\_\\  \\ \\_\\      \\ \\_\\ \\ \\_\\ \\__/.\\_\\ \\____ \\ \\_\\/\\____\\ \\____\\";
            name[6] = "    \\/_/\\/_/   \\/_/       \\/_/  \\/_/ \\/__/\\/_/\\/___L\\ \\/_/\\/____/\\/____/";
            name[7] = "                                                /\\____/                 ";
            name[8] = "                                                \\_/__/                  ";

            for (int i = 0; i < name.Length; i++)
            {
                Console.SetCursorPosition(width / 6, height / 4 + i);
                Console.WriteLine(name[i]);

            }
        }

        private static void Play(int difficulte)
        {
            Console.Clear();
            int origWidth, origHeight;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            var rand = new Random();
            int random1, random2;

            random1 = rand.Next(0, origWidth - 3);
            random2 = rand.Next(0, origHeight - 3);
            List<SnakeBody> snakeBody = new List<SnakeBody>();
            SnakeBody oldSnakeBody;
            snakeBody.Add(new SnakeBody(random1, random2, '■', 14));
            snakeBody.Add(new SnakeBody(random1 + 1, random2, '■', 14));
            snakeBody.Add(new SnakeBody(random1 + 2, random2, '■', 14));
            SnakeBody eat = new SnakeBody(rand.Next(0, origWidth), rand.Next(0, origHeight), '■', 6);
            SnakeBody eatBonus = new SnakeBody(rand.Next(0, origWidth), rand.Next(0, origHeight), '■', 4);
            SnakeBody eatMalus = new SnakeBody(rand.Next(0, origWidth), rand.Next(0, origHeight), '■', 13);
            SnakeBody eatMalusSupreme = new SnakeBody(rand.Next(0, origWidth), rand.Next(0, origHeight), '■', 7);
            bool flag = true, endGame = true;
            int value = 1, elementEat = 0, oldElementEat = 0;
            DateTime time1 = DateTime.Now;
            DateTime time2 = DateTime.Now;
            DateTime bonus1 = DateTime.Now;
            DateTime bonus2;
            DateTime Malus1 = DateTime.Now;
            DateTime timeGame = DateTime.Now;
            int posX, posY;
            char direction = ' ';
            while (endGame)
            {
                time1 = DateTime.Now;
                while (endGame)
                {


                    AddElement(eat);
                    AddElement(eatBonus);
                    AddElement(eatMalus);
                    AddElement(eatMalusSupreme);
                    Console.ForegroundColor = ConsoleColor.White;

                    time2 = DateTime.Now;
                    if (time2.Subtract(time1).TotalMilliseconds > difficulte) { break; }
                    EntryKeyBoard(ref value, ref flag, ref direction);

                    oldSnakeBody = snakeBody[0];
                    DirectionSnake(snakeBody[snakeBody.Count - 1], flag, value);
                    snakeBody.Add(new SnakeBody(snakeBody[snakeBody.Count - 1].GetPositionX(), snakeBody[snakeBody.Count - 1].GetPositionY(), snakeBody[snakeBody.Count - 1].GetForm(), 14));
                    snakeBody.Remove(oldSnakeBody);


                    endGame = ExitMap(snakeBody[snakeBody.Count - 1], origWidth, origHeight);
                    if (endGame)
                    {
                        MoveSnake(snakeBody[snakeBody.Count - 1], oldSnakeBody, difficulte);
                    }

                }

                if (endGame)
                {
                    endGame = EatBody(snakeBody);
                }
                posX = rand.Next(3, 8);
                posY = rand.Next(3, 8);
                CheckExitMalus(snakeBody[snakeBody.Count - 1], ref posX, origWidth, ref posY, origHeight);
                elementEat = SnakeEating(snakeBody[snakeBody.Count - 1], eat, rand.Next(0, origWidth), rand.Next(0, origHeight), snakeBody, elementEat, 1);
                elementEat = SnakeEating(snakeBody[snakeBody.Count - 1], eatBonus, rand.Next(0, origWidth), rand.Next(0, origHeight), snakeBody, elementEat, 10);
                elementEat = SnakeEating(snakeBody[snakeBody.Count - 1], eatMalus, rand.Next(0, origWidth), rand.Next(0, origHeight), snakeBody, elementEat, -1);
                elementEat = SnakeEating(snakeBody[snakeBody.Count - 1], eatMalusSupreme, posX, posY, snakeBody, elementEat, -10);
                if (elementEat < oldElementEat)
                {
                    snakeBody.Remove(snakeBody[snakeBody.Count - 1]);
                    snakeBody.Remove(snakeBody[snakeBody.Count - 1]);
                }
                oldElementEat = elementEat;
                if (snakeBody.Count <= 0) { endGame = false; }


                bonus2 = DateTime.Now;
                TimeTransit(ref bonus1, bonus2, difficulte, ref eatBonus, rand.Next(0, origWidth), rand.Next(0, origHeight), 4);
                TimeTransit(ref Malus1, bonus2, difficulte, ref eatMalusSupreme, posX, posY, 7);
            }
            GameOver(origWidth, origHeight, elementEat * (5000 / difficulte),timeGame);
        }

        private static void AddElement(SnakeBody element)
        {
            ColorSwitch(element.GetColor(), true);
            Console.SetCursorPosition(element.GetPositionX(), element.GetPositionY());
            Console.Write(element.GetForm());
        }

        public static void CheckExitMalus(SnakeBody snakeBody, ref int posX, int origWidth, ref int posY, int origHeight)
        {
            if (snakeBody.GetPositionX() + posX >= origWidth)
            {
                posX = snakeBody.GetPositionX() - posX;

            }
            else if (snakeBody.GetPositionX() + posX >= 0)
            {
                posX = snakeBody.GetPositionX() + posX;
            }
            else if (posX % 2 == 0)
            {
                posX = snakeBody.GetPositionX() + posX;
            }
            else
            {
                posX = snakeBody.GetPositionX() - posX;
            }


            if (snakeBody.GetPositionY() + posY >= origHeight)
            {
                posY = snakeBody.GetPositionY() - posY;

            }
            else if (snakeBody.GetPositionY() + posY >= 0)
            {
                posY = snakeBody.GetPositionY() + posY;
            }
            else if (posY % 2 == 0)
            {
                posY = snakeBody.GetPositionY() + posY;
            }
            else
            {
                posY = snakeBody.GetPositionY() - posY;
            }
        }


        public static void ColorSwitch(int number, bool flag)
        {

            switch (number)
            {
                case 0:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Black; } else { Console.BackgroundColor = ConsoleColor.Black; }
                    break;
                case 1:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Blue; } else { Console.BackgroundColor = ConsoleColor.Blue; }
                    break;
                case 2:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Cyan; } else { Console.BackgroundColor = ConsoleColor.Cyan; }
                    break;
                case 3:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkBlue; } else { Console.BackgroundColor = ConsoleColor.DarkBlue; }
                    break;
                case 4:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkCyan; } else { Console.BackgroundColor = ConsoleColor.DarkCyan; }
                    break;
                case 5:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkGray; } else { Console.BackgroundColor = ConsoleColor.DarkGray; }
                    break;
                case 6:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkGreen; } else { Console.BackgroundColor = ConsoleColor.DarkGreen; }
                    break;
                case 7:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkMagenta; } else { Console.BackgroundColor = ConsoleColor.DarkMagenta; }
                    break;
                case 8:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkRed; } else { Console.BackgroundColor = ConsoleColor.DarkRed; }
                    break;
                case 9:
                    if (flag) { Console.ForegroundColor = ConsoleColor.DarkYellow; } else { Console.BackgroundColor = ConsoleColor.DarkYellow; }
                    break;
                case 10:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Gray; } else { Console.BackgroundColor = ConsoleColor.Gray; }
                    break;
                case 11:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Green; } else { Console.BackgroundColor = ConsoleColor.Green; }
                    break;
                case 12:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Magenta; } else { Console.BackgroundColor = ConsoleColor.Magenta; }
                    break;
                case 13:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Red; } else { Console.BackgroundColor = ConsoleColor.Red; }
                    break;
                case 14:
                    if (flag) { Console.ForegroundColor = ConsoleColor.White; } else { Console.BackgroundColor = ConsoleColor.White; }
                    break;
                case 15:
                    if (flag) { Console.ForegroundColor = ConsoleColor.Yellow; } else { Console.BackgroundColor = ConsoleColor.Yellow; }
                    break;

            }



        }
        private static void TimeTransit(ref DateTime bonus1, DateTime bonus2, int difficulte, ref SnakeBody eatBonus, int random1, int random2, int color)
        {
            if (bonus2.Subtract(bonus1).TotalMilliseconds > 50 * difficulte)
            {
                Console.SetCursorPosition(eatBonus.GetPositionX(), eatBonus.GetPositionY());
                Console.Write(" ");
                eatBonus = new SnakeBody(random1, random2, '■', color);
                bonus1 = DateTime.Now;
            }

        }

        private static void EntryKeyBoard(ref int value, ref bool flag, ref char direction)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo toets = Console.ReadKey(true);
                if (toets.Key.Equals(ConsoleKey.DownArrow) && direction != 'u')
                {
                    value = 1;
                    flag = false;
                    direction = 'd';
                }
                else if (toets.Key.Equals(ConsoleKey.UpArrow) && direction != 'd')
                {
                    value = -1;
                    flag = false;
                    direction = 'u';
                }
                else if (toets.Key.Equals(ConsoleKey.RightArrow) && direction != 'l')
                {
                    value = 1;
                    flag = true;
                    direction = 'r';
                }
                else if (toets.Key.Equals(ConsoleKey.LeftArrow) && direction != 'r')
                {
                    value = -1;
                    flag = true;
                    direction = 'l';
                }
            }
        }

        private static void DirectionSnake(SnakeBody snake, bool flag, int value)
        {
            if (flag)
            {
                snake.SetPositionX(snake.GetPositionX() + value);
            }
            else
            {
                snake.SetPositionY(snake.GetPositionY() + value);
            }
        }
        private static void MoveSnake(SnakeBody snake, SnakeBody old, int time)
        {
            AddElement(snake);
            Thread.Sleep(time);
            old.SetForm(' ');
            AddElement(old);
        }

        private static bool ExitMap(SnakeBody snakeBody, int width, int height)
        {
            if (width == snakeBody.GetPositionX() || snakeBody.GetPositionX() == -1 || height == snakeBody.GetPositionY() || snakeBody.GetPositionY() == -1)
            {

                return false;
            }
            return true;
        }


        private static bool EatBody(List<SnakeBody> snakeBody)
        {
            for (int i = 0; i < snakeBody.Count - 2; i++)
            {
                if (snakeBody[i].GetPositionX() == snakeBody[snakeBody.Count - 1].GetPositionX() && snakeBody[i].GetPositionY() == snakeBody[snakeBody.Count - 1].GetPositionY())
                {
                    return false;
                }
            }
            return true;
        }

        private static int SnakeEating(SnakeBody tete, SnakeBody eat, int random1, int random2, List<SnakeBody> snakeBody, int elementEat, int point)
        {
            if (tete.GetPositionX() == eat.GetPositionX() && tete.GetPositionY() == eat.GetPositionY())
            {
                Console.SetCursorPosition(eat.GetPositionX(), eat.GetPositionY());
                Console.WriteLine(" ");
                eat.SetPositionX(random1);
                eat.SetPositionY(random2);
                snakeBody.Add(new SnakeBody(snakeBody[snakeBody.Count - 1].GetPositionX(), snakeBody[snakeBody.Count - 1].GetPositionY(), '■', 14));
                return elementEat + point;
            }
            return elementEat;
        }

        private static void GameOver(int width, int height, int score, DateTime time)
        {
            Console.Clear();
            ConsoleKeyInfo cki;
            string[] name = new string[15];
            int time2 = (DateTime.Now - time).Seconds;

            name[0] = "  ______                       _____                                             ";
            name[1] = " / _____)                     / ___ \\                                            ";
            name[2] = "| /  ___  ____ ____   ____   | |   | |_   _ ____  ____                           ";
            name[3] = "| | (___)/ _  |    \\ / _  )  | |   | | | | / _  )/ ___)                          ";
            name[4] = "| \\____/( ( | | | | ( (/ /   | |___| |\\ V ( (/ /| |                              ";
            name[5] = " \\_____/ \\_||_|_|_|_|\\____)   \\_____/  \\_/ \\____)_|                              ";
            name[6] = "                                                                                 ";
            name[7] = "    _                               ______                 _                     ";
            name[8] = "   | |                             |  ___ \\               | |                    ";
            name[9] = "    \\ \\   ___  _   _  ___    ___   | | _ | | ____  ____ _ | | ____    _   _ ____ ";
            name[10] = "     \\ \\ / _ \\| | | |/___)  (___)  | || || |/ _  )/ ___) || |/ _  )  | | | / _  |";
            name[11] = " _____) ) |_| | |_| |___ |         | || || ( (/ /| |  ( (_| ( (/ /    \\ V ( ( | |";
            name[12] = "(______/ \\___/ \\____(___/          |_||_||_|\\____)_|   \\____|\\____)    \\_/ \\_||_|";
            name[13] = "                                                                                 ";

            for (int i = 0; i < name.Length; i++)
            {
                Console.SetCursorPosition(width / 6, (height / 10) + i);
                Console.WriteLine(name[i]);
            }

            Console.SetCursorPosition(width / 6, (height / 10) + name.Length + 2);
            Console.WriteLine("score : " + score + " ce n'est pas fameux ma couille");
            Console.SetCursorPosition(width / 6, (height / 10) + name.Length + 4);
            Console.WriteLine("Time : " + time2 + " seconde, tout ca en en autant de temps ");
            do
            {
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Enter);


        }

        private static void AfficheOption(int width, int height) {
            string[] name = new string[13];
            name[0] = "   _____                                       _                             _ _ _           ";
            name[1] = "  / ____|                                     | |                           (_) | |          ";
            name[2] = " | |     __ _ ___ ___  ___   _ __   __ _ ___  | | ___  ___    ___ ___  _   _ _| | | ___  ___ ";
            name[3] = " | |    / _` / __/ __|/ _ \\ | '_ \\ / _` / __| | |/ _ \\/ __|  / __/ _ \\| | | | | | |/ _ \\/ __|";
            name[4] = " | |___| (_| \\__ \\__ \\  __/ | |_) | (_| \\__ \\ | |  __/\\__ \\ | (_| (_) | |_| | | | |  __/\\__ \\";
            name[5] = "  \\_____\\__,_|___/___/\\___| | .__/ \\__,_|___/ |_|\\___||___/  \\___\\___/ \\__,_|_|_|_|\\___||___/";
            name[6] = "  | |                       | | |     (_)             /_/                  (_)               ";
            name[7] = "  | |__  _ __ ___     ___  _|_| |_     _  ___  _   _  ___    __ _ _   _     _  ___ _   _     ";
            name[8] = "  | '_ \\| '__/ _ \\   / _ \\/ __| __|   | |/ _ \\| | | |/ _ \\  / _` | | | |   | |/ _ \\ | | |    ";
            name[9] = "  | |_) | | | (_) | |  __/\\__ \\ |_    | | (_) | |_| |  __/ | (_| | |_| |   | |  __/ |_| |    ";
            name[10] = "  |_.__/|_|  \\___/   \\___||___/\\__|   | |\\___/ \\__,_|\\___|  \\__,_|\\__,_|   | |\\___|\\__,_|    ";
            name[11] = "                                     _/ |                                 _/ |               ";
            name[12] = "                                    |__/                                 |__/                ";

            Console.Clear();
            for (int i = 0; i < name.Length; i++)
            {
                Console.SetCursorPosition(width, height + i);
                Console.WriteLine(name[i]);
            }

        }

    }

}

class SnakeBody
{
    private char form;
    private int positionX;
    private int positionY;
    private int color;

    public SnakeBody(int positionX, int positionY, char form, int color)
    {
        this.form = form;
        this.positionX = positionX;
        this.positionY = positionY;
        this.color = color;

    }

    public int GetColor()
    {
        return color;
    }

    public void SetColor(int color)
    {
        this.color = color;
    }
    public char GetForm()
    {
        return form;
    }

    public void SetForm(char form)
    {
        this.form = form;
    }

    public int GetPositionX()
    {
        return positionX;
    }

    public void SetPositionX(int PositionX)
    {
        this.positionX = PositionX;
    }
    public int GetPositionY()
    {
        return positionY;
    }

    public void SetPositionY(int positionY)
    {
        this.positionY = positionY;
    }


}
