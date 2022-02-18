using storyVariables;




// Initializing + declaring player, and player attributes
Player user = new Player(1, 1, 1, 1, 100);
int endurance = user.GetEndurance();
int focus = user.GetFocus();
int intelligence = user.GetIntelligence();
int speed = user.GetSpeed();
int gradeLevel = user.GetGrade();


//Intro
Console.WriteLine("Hello! Welcome to Eleven Fifty Trail!");

//Getting players name
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Hello {userName}!");

//Rules
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("In Eleven Fifty Trail you will be tasked with completing projects while maintaining your health, and working on passing the class.");
Console.WriteLine("You are in Eleven Fifty Academy's coding foundations course. Over the course of the next 5 weeks, you will learn the basics of coding.");
Console.WriteLine("Being on time to class won't be your own problem. You will have to grow your skills to pass challenges throughout the course.");
Console.WriteLine("You must pass with a “C” or higher, to move onto Immersion. Otherwise you will fail, and will need to repeat the course!");
Console.WriteLine("Failure to overcome the obstacles will result in a deduction in your grade level. The equivalent to failing class is losing 3 grade levels.");
Console.WriteLine("You start with a grade of A, and if you fall below a grade of C, you will fail, and have to retake the class!");
Console.WriteLine("Don't worry tho!! Through extra credit opportunities, and listening to guest speakers you could raise your grade level!");
Console.WriteLine("__________________________________________________________________________________________");

// First day
int currentDay = 1;

Console.WriteLine("Good morning! How would you like to spend your time before your first day of class? Class starts at 9am.");
Console.WriteLine("1. Sleep in and join the zoom at 8:58am.");
Console.WriteLine("2. Wake up extra early and read through the Canvas course.");
Console.WriteLine("3. Drink some coffee.");
Console.WriteLine("4. Check your current skill levels.");
Console.WriteLine("__________________________________________________________________________________________");

dayOneMorning:
string dayOneMorning = Console.ReadLine();


switch (dayOneMorning)
{
    case "1":
        Console.WriteLine("You got a lot of rest but are disoriented joining the Zoom at the last possible second.");
        user.SetEndurance(1);
        Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
        break;
    case "2":
        Console.WriteLine("You're really tired, but feel extra prepared starting the day.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}");
        break;
    case "3":
        Console.WriteLine("You chug 3 cups of coffee and are ready ace the typing tests.");
        user.SetSpeed(1);
        Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine($"Enter a number between 1 and 3.");
        goto dayOneMorning;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayOneMorning;
}




Console.WriteLine("Welcome to your first day of class! Your instructors will be Adam and Kate.");
Console.WriteLine("As you go through your first day you download the essential software, and create a README.md file.");
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("You finally get a lunch break what do you do?");
Console.WriteLine("1. Take a nap");
Console.WriteLine("2. Eat a hardy lunch");
Console.WriteLine("3. Drink some Coffee");
Console.WriteLine("4. Check you skill levels");
Console.WriteLine("__________________________________________________________________________________________");

dayOneLunch:
string dayOneLunch = Console.ReadLine();

switch (dayOneLunch)
{
    case "1":
        Console.WriteLine("You overslept and came back from lunch a hour late.");
        user.SetEndurance(1);
        Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
        break;
    case "2":
        Console.WriteLine("You ate a full lunch, you continue your day as usual.");
        break;
    case "3":
        Console.WriteLine("You chug two cups of coffee, and your typing speed reflects that.");
        user.SetSpeed(1);
        Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayOneLunch;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayOneLunch;
}

Console.WriteLine("After coming back from lunch you create a GitHub account, and you learn how to make repositories.");
Console.WriteLine("You then learn how to initialize and push your repositories to GitHub by using your systems terminal.");
Console.WriteLine("After a great first day of learning some of the basics, class is let out.");
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Now that class is over what do you do?");
Console.WriteLine("1. Play VideoGames");
Console.WriteLine("2. Look over tomorrow's lesson plan");
Console.WriteLine("3. Get an early night's sleep, to be well rested for tomorrow.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayOneNight:
string dayOneNight = Console.ReadLine();

switch (dayOneNight)
{
    case "1":
        Console.WriteLine("You played `just one more game` 6 times.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        break;
    case "2":
        Console.WriteLine("Looking over the lesson plans, you feel prepared for the challenges tomorrow could throw at you.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your intelligence is now {user.GetIntelligence()}.");
        break;
    case "3":
        Console.WriteLine("Getting a full night of sleep you wake up well rested, and ready to learn HTML!");
        user.SetEndurance(1);
        Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayOneNight;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayOneNight;
}


// Day 2
currentDay = 2;

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Welcome to day 2! How would you like to start your day?");
Console.WriteLine("1. Spend the first 25 minutes on a typing test.");
Console.WriteLine("2. Get ahead on HTML.");
Console.WriteLine("3. Make your breakfast since you woke up late.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayTwoMorning:
string dayTwoMorning = Console.ReadLine();

switch (dayTwoMorning)
{
    case "1":
        Console.WriteLine("Your WPM increases by 10! Great job!");
        user.SetSpeed(1);
        Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
        break;
    case "2":
        Console.WriteLine("Looking over the lesson plans, you feel prepared for the day.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your intelligence is now {user.GetIntelligence()}.");
        break;
    case "3":
        Console.WriteLine("You prepare a nice breakfeast that fills you up.");
        user.SetEndurance(1);
        Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayTwoMorning;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayTwoMorning;
}


Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("It's time for your first assignment! Your first assignment is the static register page!");
int assignmentOne = 2;
int intelligenceOne = user.GetIntelligence();
if (assignmentOne / intelligenceOne <= 1)
{
    Console.WriteLine("Congratulations you got a one hundred on your assignment!");
}
else if (assignmentOne / intelligenceOne <= 1.5)
{
    Console.WriteLine("You completed the assignment, and got a B!");
    user.SetGrade(-5);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else
{
    Console.WriteLine("You completed the assignment but barely got a passing grade on it.");
    user.SetGrade(-10);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
Console.WriteLine("__________________________________________________________________________________________");


Console.WriteLine("After a long morning of learning HTML, and completing your first assignment, you're given a lunch break.");
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("How do you want to spend your lunch break?");
Console.WriteLine("1. Skip lunch and keep coding on.");
Console.WriteLine("2. Take a well deserved nap.");
Console.WriteLine("3. Get some chic fil-a!");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");


dayTwoLunch:
string dayTwoLunch = Console.ReadLine();

switch (dayTwoLunch)
{
    case "1":
        Console.WriteLine("Your brain is tired, however you increased your knowledge of HTML.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        break;
    case "2":
        Console.WriteLine("You roll out of bed a minute before you needed to be back in class");
        user.SetEndurance(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        break;
    case "3":
        Console.WriteLine("After devouring some Chic Fil-A you feel a little sluggish.");
        user.SetFocus(-1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayTwoLunch;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayTwoLunch;
}


Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("You spend the rest of the day learning more HTML elements. Tomorrow you will learn CSS.");
Console.WriteLine("Now that class is dismissed, how do you spend your night?");
Console.WriteLine("1. Go straight to bed");
Console.WriteLine("2. Get ahead in tomorrow's module");
Console.WriteLine("3. Hang out with friends");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayTwoNight:
string dayTwoNight = Console.ReadLine();

switch (dayTwoNight)
{
    case "1":
        Console.WriteLine("Your brain really needed to rest after all of that learning.");
        user.SetEndurance(1);
        user.SetFocus(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        break;
    case "2":
        Console.WriteLine("You end up getting confused on the new material, and pass out from exhaustion.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        user.SetIntelligence(-1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        break;
    case "3":
        Console.WriteLine("You had a fun night but stayed up late on discord.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayTwoNight;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayTwoNight;
}

// Day Three
currentDay = 3;

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Welcome to day 3! How would you like to start your day?");
Console.WriteLine("1. Spend the first 25 minutes on a typing test.");
Console.WriteLine("2. Go through some HTML exercises on W3 schools.");
Console.WriteLine("3. Eat some hotpockets while watching YouTube.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayThreeMorning:
string dayThreeMorning = Console.ReadLine();

switch (dayThreeMorning)
{
    case "1":
        Console.WriteLine("Your WPM increases by 10! Great job!");
        user.SetSpeed(1);
        Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
        break;
    case "2":
        Console.WriteLine("While going through HTML exercises, you strengthen your HTML knowledge.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your intelligence is now {user.GetIntelligence()}.");
        break;
    case "3":
        Console.WriteLine("You enjoy your hotpockets while you watch some PewDiePie.");
        user.SetFocus(-1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayThreeMorning;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayThreeMorning;
}

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Today, You are learning CSS.");
Console.WriteLine("You enjoy making HTML pretty!");
Console.WriteLine("");
Console.WriteLine("You get work time for your next assignment, the Static StoreFront Page");
Console.WriteLine("The assignment is due on day 5");
Console.WriteLine("__________________________________________________________________________________________");

int staticStorefront = 6;
int dayThreeWorkTimeIntelligence = user.GetIntelligence();

Console.WriteLine("How do you spend your worktime?");
Console.WriteLine("1. Spend all of the time working on the assignment, without a break.");
Console.WriteLine("2. Take a nap and do the assignment later.");
Console.WriteLine("3. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayThreeWorkTime:
string dayThreeWorkTime = Console.ReadLine();

switch (dayThreeWorkTime)
{
    case "1":
        Console.WriteLine("You give it your all, and you came a long ways.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your typing speed is now {user.GetEndurance()}.");
        staticStorefront = staticStorefront - dayThreeWorkTimeIntelligence;
        if (staticStorefront <= 0)
        {
            Console.WriteLine("Congrats you finished the project in one sitting");
        }
        else
        {
            Console.WriteLine("You still have some work left to do for the Storefront.");
        }
        break;
    case "2":
        Console.WriteLine("You sleep during worktime, and did not make any progress on the Static Storefront.");
        user.SetEndurance(1);
        Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
        break;
    case "3":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayThreeWorkTime;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayThreeWorkTime;
}



Console.WriteLine("You feel good about how you spent the day's worktime.");
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Now that class is out, how do you spend the night?");
Console.WriteLine("1. Work on the Static StoreFront for two more hours.");
Console.WriteLine("2. This HTML is getting out of hand, go straight to bed!");
Console.WriteLine("3. Play Minecraft.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");


dayThreeNight:
string dayThreeNight = Console.ReadLine();
int dayThreeNightIntelligence = user.GetIntelligence();

switch (dayThreeNight)
{
    case "1":
        Console.WriteLine("You spend a couple hours working on the assignment.");
        staticStorefront = staticStorefront - dayThreeNightIntelligence;
        if (staticStorefront <= 0)
        {
            Console.WriteLine("Congrats you finished the project in one sitting");
        }
        else
        {
            Console.WriteLine("You still have some work left to do for the Storefront.");
        }
        break;
    case "2":
        Console.WriteLine("From looking at a screen all day you find discomfort in trying to sleep, but are well rested.");
        user.SetEndurance(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        break;
    case "3":
        Console.WriteLine("You find a village, and then go mining for diamonds.");
        user.SetIntelligence(-1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        Console.WriteLine("Your diamond count is still 0.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayThreeNight;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayThreeNight;
}


// Day Four

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Welcome to day 4! You will be learning some more CSS tricks today!");
Console.WriteLine("You have a lecture from 9:30 to noon!");
Console.WriteLine("How do you spend the time during the lecture?");
Console.WriteLine("1. Paying close attention, and taking diligent notes as you follow along.");
Console.WriteLine("2. Pay attention to the lecture, while also working on you Static StoreFront page.");
Console.WriteLine("3. Play More Minecraft.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayFourLecture:
string dayFourLecture = Console.ReadLine();

int dayFourLectureIntelligence = user.GetIntelligence();

switch (dayFourLecture)
{
    case "1":
        Console.WriteLine("You absorb the content well!");
        user.SetIntelligence(1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        break;
    case "2":
        Console.WriteLine("You make progress following the new tricks you learn during the lecture, but you don't absorb all of the knowledge.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        staticStorefront = staticStorefront - dayFourLectureIntelligence;
        if (staticStorefront <= 0)
        {
            Console.WriteLine("Congrats you finished the project in one sitting");
        }
        else
        {
            Console.WriteLine("You still have some work left to do for the Storefront.");
        }
        break;
    case "3":
        Console.WriteLine("You find three diamonds, but can't barter for CSS potions.");
        user.SetFocus(-1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        Console.WriteLine("Your diamond count is now 3!");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayFourLecture;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayFourLecture;
}


Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("After a great lecture, you are released for lunch.");
Console.WriteLine("How do you spend lunch time?");
Console.WriteLine("1. Take another nap!");
Console.WriteLine("2. Spend time on the Static StoreFront Assignment");
Console.WriteLine("3. Taco Tuesday!");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayFourLunch:
string dayFourLunch = Console.ReadLine();

int dayFourLunchIntelligence = user.GetIntelligence();

switch (dayFourLunch)
{
    case "1":
        Console.WriteLine("You spend your lunch break sleeping, you are now well rested, but hungry.");
        user.SetEndurance(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        user.SetFocus(-1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        break;
    case "2":
        Console.WriteLine("You make progress following the new tricks you learn during the lecture, but feel hungry and drained.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        staticStorefront = staticStorefront - dayFourLectureIntelligence;
        if (staticStorefront <= 0)
        {
            Console.WriteLine("Congrats you finished the project in one sitting");
        }
        else
        {
            Console.WriteLine("You still have some work left to do for the Storefront.");
        }
        break;
    case "3":
        Console.WriteLine("You eat a burrito for taco tuesday :(");
        user.SetFocus(1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayFourLunch;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayFourLunch;
}

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("After you come back from lunch, you watch youtube CSS tutorials.");
Console.WriteLine("You are given a new assignment.");
Console.WriteLine("The assignment is a CSS Checkup, and it is due tomorrow at 9am.");
int cssCheckup = 3;
int dayFourNightIntelligence = user.GetIntelligence();

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Now that class is over how do you wish to spend your time?");
Console.WriteLine("1. Work on the CSS CheckUp");
Console.WriteLine("2. Spend time on the Static StoreFront Assignment");
Console.WriteLine("3. Go to bed!");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayFourNight:
string dayFourNight = Console.ReadLine();


switch (dayFourNight)
{
    case "1":
        Console.WriteLine("You spend your night working on the CSS Checkup, giving it your all.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        cssCheckup = cssCheckup - dayFourNightIntelligence;
        if (cssCheckup <= 0)
        {
            Console.WriteLine("Congrats you finished your CSS checkup assignment, however your friends stole your diamonds.");
        }
        else
        {
            Console.WriteLine("You made good progress on the assignment, and called it a night.");
        }
        break;
    case "2":
        Console.WriteLine("You make progress following the new tricks you learn during the lecture, but feel drained.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        staticStorefront = staticStorefront - dayFourNightIntelligence;
        if (staticStorefront <= 0)
        {
            Console.WriteLine("Congrats you finished the project in one sitting");
        }
        else
        {
            Console.WriteLine("You still have some work left to do for the Storefront.");
        }
        break;
    case "3":
        Console.WriteLine("You feel good about CSS, and reward yourself with some sleep.");
        user.SetEndurance(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayFourNight;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayFourNight;
}


// Day FIVE!
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Welcome to day five of Eleven Fifty Trail. Today, both your static storefront, and CSS Checkup are due today.");
Console.WriteLine("How would you like to spend your morning?");
Console.WriteLine("1. Work on the CSS CheckUp");
Console.WriteLine("2. Spend time on the Static StoreFront Assignment");
Console.WriteLine("3. Sleep in since you were on top of everything.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

dayFiveMorning:
string dayFiveMorning = Console.ReadLine();
int dayFiveMorningIntelligence = user.GetIntelligence();

switch (dayFiveMorning)
{
    case "1":
        Console.WriteLine("You wake up early to work on the CSS Checkup, giving it your all.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        cssCheckup = cssCheckup - dayFiveMorningIntelligence;
        if (cssCheckup <= 0)
        {
            Console.WriteLine("Congrats you finished your CSS checkup assignment, however you regret procrastinating.");
        }
        else
        {
            Console.WriteLine("You made good progress on the assignment, but didn't finish it.");
        }
        break;
    case "2":
        Console.WriteLine("You wake up early, and regret procrastinating until the last minute.");
        user.SetEndurance(-1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        staticStorefront = staticStorefront - dayFourNightIntelligence;
        if (staticStorefront <= 0)
        {
            Console.WriteLine("Congrats you finished the project.");
        }
        else
        {
            Console.WriteLine("You still have some work left to do for the Storefront.");
        }
        break;
    case "3":
        Console.WriteLine("You reward yourself with sleep for not procrastinating.");
        user.SetEndurance(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        user.SetFocus(1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayFiveMorning;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayFiveMorning;
}

// Static StoreFront due, grade check
if (staticStorefront <= 0)
{
    Console.WriteLine("Congratulations you got a one hundred on the Static Storefront Assignment!");
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else if (staticStorefront <= 1)
{
    Console.WriteLine("You completed the Static StoreFront assignment, and got a B!");
    user.SetGrade(-5);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else if (staticStorefront == 6)
{
    Console.WriteLine("You did not do any work on your Static StoreFront assignment.");
    user.SetGrade(-10);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else
{
    Console.WriteLine("You completed the Static StoreFront assignment, but barely got a passing grade on it.");
    user.SetGrade(-7);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}



// CSS Checkup due, Grade Check
if (cssCheckup <= 0)
{
    Console.WriteLine("Congratulations you got a one hundred on the CSS Checkup Assignment!");
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else if (cssCheckup <= 1)
{
    Console.WriteLine("You completed the CSS Checkup, and got a B!");
    user.SetGrade(-3);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else if (cssCheckup == 3)
{
    Console.WriteLine("You did not do any work on your CSS Checkup.");
    user.SetGrade(-8);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}
else
{
    Console.WriteLine("You completed the CSS Checkup but barely got a passing grade on it.");
    user.SetGrade(-5);
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
}

Console.WriteLine("Congrats you have no current assignments, and will be able to enjoy the weekend how you want.");
Console.WriteLine("After the morning typing test, you wrap up learning about CSS.");
Console.WriteLine("Before you head out to lunch, Adam talks about learning CSharp next week.");
Console.WriteLine("He tells you that you're not going to get it.");
Console.WriteLine("He says he's not trying to scare yo, but that he is trying to scare you.");
Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("After you come back from lunch you have a guess speaker.");
Console.WriteLine("How do you spend your time with the guest speaker?");
Console.WriteLine("1. Listen intenslive and take notes.");
Console.WriteLine("2. Leave the zoom on and take a nap.");
Console.WriteLine("3. Listen to the speaker, and stay latte to ask questions.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");
dayFiveLunch:
string dayFiveLunch = Console.ReadLine();


switch (dayFiveLunch)
{
    case "1":
        Console.WriteLine("You learn a great deal from the speaker, and are inspired for th weekend.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        break;
    case "2":
        Console.WriteLine("You don't hear anything that the speaker says, but get some needed rest.");
        user.SetEndurance(1);
        Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
        user.SetIntelligence(-1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        break;
    case "3":
        Console.WriteLine("You learn a great deal from the speaker, and increase your linkden connections.");
        user.SetFocus(1);
        Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
        user.SetIntelligence(1);
        Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
        break;
    case "4":
        Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
        Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
        Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
        Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
        Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
        Console.WriteLine("Now Enter a number between 1 and 3.");
        goto dayFiveLunch;
    default:
        Console.WriteLine("Enter a number between 1 and 3.");
        goto dayFiveLunch;
}

// Day 6
Console.WriteLine("Good Morning! Welcome to Day 6! You had a good restful weekend after your first week at EFA.");
Console.WriteLine("This week you will start learning C#, how do you spend your morning?");
Console.WriteLine("1. Practice your typing through SpeedCoder.");
Console.WriteLine("2. Get some extra sleep through type time.");
Console.WriteLine("3. Get ahead on the C# lesson for today.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("__________________________________________________________________________________________");

daySixMorning:
string daySixMorning = Console.ReadLine();





{
    switch (daySixMorning)
    {
        case "1":
            Console.WriteLine("Your WPM is now around 30, but you managed to increase it around 3 WPM. Good job.");
            user.SetSpeed(1);
            Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
            break;
        case "2":
            Console.WriteLine("You enjoyed the extra sleep but wake up groggy a minute before Zoom.");
            user.SetFocus(-1);
            Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
            break;
        case "3":
            Console.WriteLine("You are hopelessly confused.");
            user.SetIntelligence(-2);
            Console.WriteLine($"Your focus skill is now {user.GetIntelligence()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto daySixMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto daySixMorning;
    }
}


currentDay = 6;
Console.WriteLine("During your first C# lesson, you run into an error.");
Console.WriteLine("How do you go about fixing it?");

Console.WriteLine("1. Ask the instructor how to fix it.");
Console.WriteLine("2. Do a Google search.");
Console.WriteLine("3. Check Stats");

daySixAfternoon:
string daySixAfternoon = Console.ReadLine();
int daySixAfternoonIntelligence = user.GetIntelligence();

{
    switch (daySixAfternoon)
    {
        case "1":
            Console.WriteLine("Your instructor had to stop the lesson for everyone, but after 15 minutes you solve your problem.");
            break;
        case "2":
            Console.WriteLine("After a few minutes of digging, you find the solution to your problem! No more error!");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto daySixAfternoon;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto daySixAfternoon;
    }
}


Console.WriteLine("_____________________________________________________________");


Console.WriteLine("Congrats you finished your first day of C#!");
Console.WriteLine("You brain is super tired, what do you do for the rest of the day?");
Console.WriteLine("1. Cry from C#");
Console.WriteLine("2. Go straight to bed");
Console.WriteLine("3. Go back and review some of the day's material.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
daySixNight:
string daySixNight = Console.ReadLine();

{
    switch (daySixNight)
    {
        case "1":
            Console.WriteLine("After crying, you feel much better");
            user.SetFocus(1);
            Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
            break;
        case "2":
            Console.WriteLine("The sleep helped a lot, you wake up ready to learn more.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "3":
            Console.WriteLine("You start to learn the structure and syntax of C#, but now have a headache.");
            user.SetIntelligence(2);
            Console.WriteLine($"Your focus skill is now {user.GetIntelligence()}.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto daySixNight;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto daySixNight;
    }
}


// END OF GAME
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("Congratulations you made it through six days of class. Let's check and see if you're passing");
gradeLevel = user.GetGrade();

if (gradeLevel >= 90)
{
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
    Console.WriteLine("Congratulations you have an A in the class.");
}
else if (gradeLevel >= 80)
{
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
    Console.WriteLine("Congratulations you are passing with a B! Good Job!");
}
else if (gradeLevel >= 70)
{
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
    Console.WriteLine("You are barely passing the class with a C.");

}
else
{
    Console.WriteLine($"Your current grade is {user.GetGrade()}%");
    Console.WriteLine("You are failing the class, you need to complete assignments to bring your grade up!");
}

Console.WriteLine("__________________________________________________________________________________________");
Console.WriteLine("Thank you for playing Eleven Fifty Trail. We hope you enjoyed!");
Console.WriteLine("__________________________________________________________________________________________");

namespace storyVariables
{
    class Player
    {
        // constructor
        public Player(int endurance, int focus, int intelligence, int speed, int gradeLevel)
        {
            // setting user skills so we can increase them seprate from the original constructor
            userEndurance = endurance;
            userFocus = focus;
            userIntelligence = intelligence;
            userSpeed = speed;
            userGrade = gradeLevel;

        }
        // Methods
        public int GetEndurance()
        {
            return userEndurance;
        }

        public void SetEndurance(int enduranceChange)
        {
            userEndurance = userEndurance + enduranceChange;
        }

        public int GetFocus()
        {
            return userFocus;
        }

        public void SetFocus(int focusChange)
        {
            userFocus = userFocus + focusChange;
        }

        public int GetIntelligence()
        {
            return userIntelligence;
        }

        public void SetIntelligence(int IntelligenceChange)
        {
            userIntelligence = userIntelligence + IntelligenceChange;
        }

        public int GetSpeed()
        {
            return userSpeed;
        }

        public void SetSpeed(int SpeedChange)
        {
            userSpeed = userSpeed + SpeedChange;
        }

        public int GetGrade()
        {
            return userGrade;
        }

        public void SetGrade(int GradeChange)
        {
            userGrade = userGrade + GradeChange;
        }



        // Properties
        public int userEndurance { get; set; }
        public int userFocus { get; set; }
        public int userIntelligence { get; set; }
        public int userSpeed { get; set; }
        public int userGrade { get; set; }

    }


}