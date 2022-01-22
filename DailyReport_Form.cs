  //name at top of page
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();

//Name of Questionaire
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

//asks name and let's student input
            Console.WriteLine("What is your name?");
            string UserName = Console.ReadLine();

            //asks coursename and let's student input a string
            Console.WriteLine("What Course are you on?");
            string CourseName = Console.ReadLine();

            //asks page number and let's student input an integer
            Console.WriteLine("What page number?");
            int PageNumber = Convert.ToInt32(Console.ReadLine());

            //asks if students need help and let's student input a bool
            Console.WriteLine("Do you need help with anything Please answer \" true \" or \"false \"?");
            bool HelpPlease = Convert.ToBoolean(Console.ReadLine());

            //asks esperience and let's student input a string.
            Console.WriteLine("Were there any positive experiences You'd like to share? Please give specifics.");
            string ExperienceToday = Console.ReadLine();

            //asks feedback and let's student input a string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics.");
            string FeedBack = Console.ReadLine();

            //asks student hours studied and let's student input an integer
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

