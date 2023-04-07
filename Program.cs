using System;

class Program {
    static void Simple_Interest() {

        Console.WriteLine("Simple Interest Calculator\n\nThe Formula is:  I = Prt ");

        Console.Write("Finding the value of (I / P / r / t)\n\nPick one: ");
        string ans = Console.ReadLine().ToUpper();

        switch (ans) {

            case "I":
                Console.WriteLine("\nThe Formula is: I = A - P");

                Console.Write("\nEnter the value of  A: ");
                double maturity_Value = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the value of  P: ");
                double principal = Convert.ToInt32(Console.ReadLine());

                double interest = maturity_Value - principal;
                Console.WriteLine($"\nI = {interest}\n");

                while (true) {
                    Console.Write("Finding the value of (r / t)\nPick one: ");
                    string ans2 = Console.ReadLine().ToUpper();

                    // Fix Later on, Line 66 to 73
                    if (ans2 == "R") {
                        Console.Write("Enter the value of t: ");
                        double term = Convert.ToInt32(Console.ReadLine());

                        double rate = interest / (principal * term);

                        Console.WriteLine(rate * 100);
                        break;

                    }
                    else if (ans2 == "T") {
                        Console.Write("Enter the value of r: ");
                        double rate = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"t = {interest / (principal * (rate / 100))}");
                        break;
                    }
                    else {
                        Console.WriteLine("\nPlease try again");
                        continue;
                    }
                }
                break;

            case "P":
                Console.WriteLine("The formula is: I = (P)rt");

                Console.Write("\nEnter the value of I: ");
                double interest2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the value of r: ");
                double rate2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the value of t: ");
                double term2 /*or time*/ = Convert.ToInt32(Console.ReadLine());

                double principal2 = interest2 / ((rate2 / 100) * term2);
                Console.WriteLine($"\nP = {principal2}");

                Console.Write("\nFinding Maturity Value? (yes/no): ");
                string ans3 = Console.ReadLine().ToUpper();

                if (ans3 == "YES") {
                    Console.WriteLine($"\nA = {principal2 + interest2}");
                }
                break;

            case "R":
                Console.WriteLine("Formula is: I = P(r)t");

                Console.Write("\nEnter the value of I (2 formulas)\n1) I = A - P\n2) I = inputed in keyboard\nPick one: ");
                string ans4 = Console.ReadLine();

                switch (ans4) {

                    case "1":
                        Console.Write("\nEnter the value of  A: ");
                        double maturity_Value2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter the value of  P: ");
                        double principal3 = Convert.ToInt32(Console.ReadLine());

                        double interest3 = maturity_Value2 - principal3;
                        Console.WriteLine($"\nI = {interest3}\n");

                        Console.Write("\nEnter the value of t: ");
                        double term3 = Convert.ToInt32(Console.ReadLine());

                        double rate3 = interest3 / (principal3 * term3);

                        Console.WriteLine($"\nr = {rate3 * 100}");
                        break;

                    case "2":
                        Console.Write("Enter the value of I: ");
                        double interest4 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter the value of  P: ");
                        double principal4 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the value of t: ");
                        double term4 = Convert.ToInt32(Console.ReadLine());

                        double rate4 = (interest4 / (principal4 * term4)) * 100;
                        Console.WriteLine($"\nr = {rate4}");

                        Console.Write("\nFinding Maturity Value? (yes/no): ");
                        string anz = Console.ReadLine().ToUpper();

                        if (anz == "YES") {
                            Console.WriteLine($"\nA = {principal4 + interest4}");
                        }
                        break;
                }
                break;

            case "T":
                Console.Write("The formula is: I = Pr(t)");

                Console.Write("\nEnter the value of I (2 formulas)\n1) I = A - P\n2) I = inputed in keyboard\nPick one: ");
                string ans5 = Console.ReadLine();

                switch (ans5) {

                    case "1":
                        Console.Write("\nEnter the value of  A: ");
                        double maturity_Value3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter the value of  P: ");
                        double principal4 = Convert.ToInt32(Console.ReadLine());

                        double interest4 = maturity_Value3 - principal4;
                        Console.WriteLine($"\nI = {interest4}\n");

                        Console.Write("\nEnter the value of t: ");
                        double rate4 = Convert.ToInt32(Console.ReadLine());

                        double term4 = interest4 / (principal4 * (rate4 / 100));

                        Console.WriteLine($"\n t = {term4}");

                        break;

                    case "2":

                        Console.Write("Enter the value of I: ");
                        double interest5 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter the value of  P: ");
                        double principal5 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the value of r: ");
                        double rate5 = Convert.ToInt32(Console.ReadLine());

                        double term5 = interest5 / (principal5 * (rate5 / 100));
                        Console.WriteLine($"\nt = {term5}");

                        Console.Write("\nFinding Maturity Value? (yes/no): ");
                        string anz2 = Console.ReadLine().ToUpper();

                        if (anz2 == "YES") {
                            Console.WriteLine($"\nA = {principal5 + interest5}");
                        }
                        break;
                }
                break;

            default:
                Console.Write("\nEnter the value of P: ");
                double principal_ = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the value of r: ");
                double rate_ = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the value of t: ");
                double term_ /* or time*/ = Convert.ToInt32(Console.ReadLine());

                double interest_ = (principal_ * (rate_ / 100) * term_);
                Console.WriteLine($"\nI = {interest_}");

                Console.Write("Finding Maturity Value? (yes/no) ");
                string ans_ = Console.ReadLine().ToUpper();

                if (ans_ == "YES") {
                    Console.WriteLine($"\nA = P + I\n\nA = {principal_ + interest_}");
                }
                break;
        }
    }
    static void Compound_Interest() {
        Console.WriteLine("The formula is: A = P (1 + r / n)^n×t");

        Console.Write("\nPrincipal: ");
        long principal = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nRate: ");
        double rate = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nTerm or time: ");
        long time = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n1) Annually\n2) Semi-annually\n3) Quarterly\nn = ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n) {
            case 1:
                double rateResult = rate / 100;
                long timeResult = time * 1;

                double powerResult = Math.Pow(1 + rateResult, timeResult);
                double multiplyResult = principal * powerResult;
                Console.WriteLine($"\n\nA = {multiplyResult}");
                break;

            case 2:
                double rateResult2 = (rate / 100) / 2;
                long timeResult2 = time * 2;

                double powerResult2 = Math.Pow(1 + rateResult2, timeResult2);
                double multiplyResult2 = principal * powerResult2;
                Console.WriteLine($"\n\nA = {multiplyResult2}");
                break;

            case 3:
                double rateResult3 = (rate / 100) / 3;
                long timeResult3 = time * 3;

                double powerResult3 = Math.Pow(1 + rateResult3, timeResult3);
                double multiplyResult3 = principal * powerResult3;
                Console.WriteLine($"\n\nA = {multiplyResult3}");
                break;
        }
        Console.WriteLine("\nYou can round off the answer if you want");
    }

    static void Simple_Annuity() {
        Console.WriteLine("Welcome to my simple annuity calculator :)");
        int ans;

        while (true) {
            try {
                Console.Write("\nFinding?\n1) Ordinary\n2) Due\n");
                Console.Write("Pick one: ");
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 1) { // Ordinary
                    ans --; // ans = 0, i just re-used the variable

                    Console.Write("\nFinding?\n1) Future Value\n2) Present Value\nPick one: ");
                    ans = Convert.ToInt32(Console.ReadLine());

                    if (ans == 1) {
                        Console.Write("Enter the value of r: ");
                        double rate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the value of m: ");
                        double compoundingPeriod = Convert.ToInt32(Console.ReadLine());

                        double interestRate = (rate / 100) / compoundingPeriod;
                        Console.WriteLine ($"i = {interestRate}"); 

                        Console.Write("\nThe value of p: ");
                        double principal = Convert.ToInt32 (Console.ReadLine ());

                        Console.Write("\nThe value of t: ");
                        double term = Convert.ToInt32(Console.ReadLine());

                        double n = compoundingPeriod * term;
                        Console.WriteLine($"n = {n}");

                        Console.WriteLine($"\nFV = {Future_Value(principal, interestRate, n)}");

                    } else if (ans == 2) { 
                        Console.Write("Enter the value of r: ");
                        double rate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the value of m: ");
                        double compoundingPeriod = Convert.ToInt32(Console.ReadLine());

                        double interestRate = (rate / 100) / compoundingPeriod;
                        Console.WriteLine($"i = {interestRate}");

                        Console.Write("\nThe value of p: ");
                        double principal = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nThe value of t: ");
                        double term = Convert.ToInt32(Console.ReadLine());

                        double n = -(compoundingPeriod * term); // This is will convert to negative result 
                        Console.WriteLine($"n = {n}");

                        Console.WriteLine($"\nPV = {Present_Value(principal, interestRate, n)}"); 
                    }
                    else {
                        throw new ArgumentException("Try Again");
                    }
                }
                else if (ans == 2) {// Due ()

                    Console.Write("\nFinding?\n1) Future Value\n2) Present Value\nPick one: ");
                    ans = Convert.ToInt32(Console.ReadLine());
                    if (ans == 1) {
                        Console.Write("Enter the value of r: ");
                        double rate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the value of m: ");
                        double compoundingPeriod = Convert.ToInt32(Console.ReadLine());

                        double interestRate = (rate / 100) / compoundingPeriod;
                        Console.WriteLine($"i = {interestRate}");

                        Console.Write("\nThe value of p: ");
                        double principal = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nThe value of t: ");
                        double term = Convert.ToInt32(Console.ReadLine());

                        double n = compoundingPeriod * term;
                        Console.WriteLine($"n = {n}");
                        Console.WriteLine($"\nFV = {Future_Value(principal, interestRate, n) * (1 + interestRate)}");
                    } else if (ans == 2) {
                        Console.Write("Enter the value of r: ");
                        double rate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the value of m: ");
                        double compoundingPeriod = Convert.ToInt32(Console.ReadLine());

                        double interestRate = (rate / 100) / compoundingPeriod;
                        Console.WriteLine($"i = {interestRate}");

                        Console.Write("\nThe value of p: ");
                        double principal = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nThe value of t: ");
                        double term = Convert.ToInt32(Console.ReadLine());

                        double n = -(compoundingPeriod * term); // This is will convert to negative result 
                        Console.WriteLine($"n = {n}");

                        Console.WriteLine($"\nPV = {Present_Value(principal, interestRate, n) * (1 + interestRate)}");
                    }

                }
                else {
                    throw new ArgumentException("Try again");
                }
                break;
            }
            catch (Exception) {
                Console.WriteLine("Try again");
                continue;
            }

        } 
    }
    static void General_Annuity () {     
        while (true) {
            try {
                Console.WriteLine("Welcome to my General Annuity calculator");
                Console.Write("Finding?\n1) Future Value\n2) Present Value\nPick One: ");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 1) {
                    Console.WriteLine("\nFinding the value of j & n.");
                    Console.Write("Enter the value of r: ");
                    double InterestRate = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the value of m1: ");
                    double mSub1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the value of m2: ");
                    double mSub2 = Convert.ToInt32(Console.ReadLine());

                    // total values in j, n are in below
                    double j = J_in_General_Annuity(InterestRate, mSub1, mSub2); 
                    double n = mSub2 * mSub1;

                    Console.WriteLine($"j = {j}\nn = {n}");

                    Console.Write("\nEnter the value of p: ");
                    double principal = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nFV = {Future_Value(principal, j, n)}");
                    
                } else if (ans == 2) {
                    Console.WriteLine("\nFinding the value of j & n.");
                    Console.Write("Enter the value of r: ");
                    double InterestRate = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the value of m1: ");
                    double mSub1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the value of m2: ");
                    double mSub2 = Convert.ToInt32(Console.ReadLine());

                    // total values in j, n are in below
                    double j = J_in_General_Annuity(InterestRate, mSub1, mSub2);
                    double n = -(mSub2 * mSub1);

                    Console.WriteLine($"j = {j}\nn = {n}");

                    Console.Write("\nEnter the value of p: ");
                    double principal = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nPV = {Present_Value (principal, j, n)}");
                }
                break;
            } catch (Exception) {
                Console.WriteLine("Try Again.");
                continue;
            }
        }
       
    }
    static double Future_Value (double principal, double interestRate, double n) { //Future Value formula
        double exponent = Math.Pow(1 + interestRate, n);
        return principal * ((exponent - 1) / interestRate);
    }
    static double Present_Value (double principal, double interestRate, double n) { //Present Value formula
        double exponent = Math.Pow(1 + interestRate, n);
        return principal * ((1 - exponent) / interestRate);
    }
    static double J_in_General_Annuity (double rate, double m1, double m2) { // calculating the variable j in General Annuity
        double divideTwoSubs = m2 / m1;
        double result = (1 + (rate / 100) / m2); // result inside of parenthesis
        double result2 =  Math.Pow (result, divideTwoSubs ); 
        return result2 - 1; // final result
    }
    static void Main() {

        //Console.Write (0.49019607843137253 * 100); 
        Console.WriteLine ("________________________________________________________\n");          
        Console.WriteLine ("      _____________________________________________\n");
        Console.WriteLine ("          Welcome to My Business Math Calculator\n");
        Console.WriteLine ("        '2nd Grading Topic in General Mathematics'");
        Console.WriteLine ("      _____________________________________________\n\n");
       
       
        Console.WriteLine ("\n           What Formula do you want to use?");
        Console.WriteLine ("           ________________________________\n");
        Console.WriteLine ("                •   Simple Interest   •");
        Console.WriteLine ("                •   Compund Interest  •");
        Console.WriteLine ("                •   Simple Annuity    •");
        Console.WriteLine ("                •   General Annuity   •");
        Console.WriteLine ("           ________________________________\n");  
        Console.WriteLine ("________________________________________________________");  
        
        while (true) {
            Console.Write ("\nPick one: ");
            string ans_in_choice = Console.ReadLine ().ToUpper ();
            
            try {
                Console.WriteLine ();
                if (ans_in_choice == "SIMPLE INTEREST") {        
                    Simple_Interest ();
                    
                } else if (ans_in_choice == "COMPOUND INTEREST") {
                    Compound_Interest ();
                    
                } else if (ans_in_choice == "SIMPLE ANNUITY") {
                    Simple_Annuity ();
                    
                }else if (ans_in_choice == "GENERAL ANNUITY") {
                     General_Annuity ();
                  
                } else {
                    throw new ArgumentException ("Try Again");
                }
                break;    
            } catch  (Exception) {
                Console.WriteLine ("Try again");
                continue;
            }
        }
        Console.WriteLine("You can round off the final answer if you want.");
        Console.ReadKey();

    }
}