using System;

class Program {

    static void Main () {

        

        string guestName, discountType;

        int roomRate, no_childrens, no_Adult, no_Days, roomNumber, roomType, payment, change, result;

        int subTotal = 0;

        int subTotal2 = 0;

        

        // ang ginagawa ng \n ay gumagawa ng panibagong linya mga lodi sshesssh 

        Console.WriteLine ("\n                 ~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine ("                 |                     |");

        Console.WriteLine ("                 |        HOTEL        |");

        Console.WriteLine ("                 |     RESERVATION     |");         

        Console.WriteLine ("                 |                     |");

        Console.WriteLine ("                 ~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine ("                BOOK YOUR RESERVATION NOW!");

        

        Console.Write ("\nGuest name: ");

        guestName = Console.ReadLine ();

        

        

        Console.WriteLine ("\n                       PICK ROOM TYPE");

        Console.WriteLine ("                ~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine ("                |  1  |  SINGLE           |");

        Console.WriteLine ("                |  2  |  DOUBLE           |");

        Console.WriteLine ("                |  3  |  DELUXE           |");

        Console.WriteLine ("                |  4  |  SUITE            |");

        Console.WriteLine ("                ~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        

        Console.Write ("Room type: ");

        roomType = Convert.ToInt32 (Console.ReadLine ());

        

        

        switch (roomType) {

             

            

            case 1:

            

            roomRate = 1000;

            subTotal  += roomRate;

            Console.WriteLine ($"\nRoom rate: Php {roomRate}\nSub Total: Php {subTotal}");

            

            

            Console.WriteLine ("\n                     PICK ROOM NUMBER");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine ("        |   101   |   102   |   103   |   104   |");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            

            while (true) {    

                Console.Write ("\nEnter Room Number: ");

                roomNumber = Convert.ToInt32 (Console.ReadLine ());

                

                

                

                if (roomNumber == 101 || roomNumber == 102 || roomNumber == 103 || roomNumber == 104) {

                    

                    

                    Console.WriteLine ("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");

                    Console.Write ("\nNumber of days: ");

                    no_Days = Convert.ToInt32 (Console.ReadLine ());

                    

                    /* Fix later

                    int result = subTotal * roomNumber; */

                    Console.WriteLine ("Subtotal: Sorry po hindi ko na po alam");

                    

                    Console.Write ("Number of Children: ");

                    no_childrens = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.Write ("Number of Adults: ");

                    no_Adult = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.WriteLine ("\n                    PICK DISCOUNT TYPE ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •REGULAR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •SENIOR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                       •SUPER CARD•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                        •HOLIDAYS•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    

                    

                    Console.Write ("\nEnter Discount type: ");

                    discountType = Console.ReadLine ().ToUpper ();

                    

                    Convert.ToDouble (subTotal);

                    

                    

                    switch (discountType) {

                        

                        case "REGULAR":

                            

                            Console.WriteLine ($"Sub Total: {subTotal2+=subTotal}");

                            

                            int i = 1;

                            for (int row = 1; row <= i; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SINGLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day:  (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change}");

                                    

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i++;

                                }

                            } 

                            

                            

                            

                            

                            

                        break;

                        

                        case "SENIOR":

                            Convert.ToDouble (subTotal2);

                            

                            double discount    = subTotal * 0.2;

                            double discountedPrice = subTotal - discount;

                            Console.WriteLine ($"Subtotal: { discountedPrice}");

                            

                            

                            int i2 = 1;

                            for (int row = 1; row <= i2; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                change =  payment - subTotal;

                                

                                if (subTotal <= payment) {

                                    

                                    change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SINGLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day:  (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+200}");

                            

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i2++;

                                }

                            } 

                        break;

                        

                        case "SUPER CARD":

                            

                            double discountedPrice2 = subTotal - (subTotal * 0.05);

                            Console.WriteLine ($"Subtotal: {discountedPrice2}");

                            

                            int i3 = 1;

                            for (int row = 1; row <= i3; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                    change =  payment - subTotal;

                                    

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SINGLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day:  (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal2}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i3++;

                                }

                            } 

                        break;

                            

                        case "HOLIDAYS":

                            double discountedPrice3 = subTotal - (subTotal * 0.10);

                            Console.WriteLine ($"\nSubtotal: {discountedPrice3}");

                            

                            int i4 = 1;

                            for (int row = 1; row <= i4; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change =  payment - subTotal;

                                    

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SINGLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change: {change+100}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i4++;

                                }

                            } 

                            

                            

                            

                            

                        break;

                    } 

                    

                    

                    break;

                }

                

            }

            

            break;

            case 2:

            

            roomRate = 2000;

            subTotal  += roomRate;

            Console.WriteLine ($"\nRoom rate: Php {roomRate}\nSub Total: Php {subTotal}");

            

            

            Console.WriteLine ("\n                     PICK ROOM NUMBER");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine ("        |   201   |   202   |   203   |   204   |");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            

            while (true) {    

                Console.Write ("\nEnter Room Number: ");

                roomNumber = Convert.ToInt32 (Console.ReadLine ());

                

                

                

                if (roomNumber == 201 || roomNumber == 202 || roomNumber == 203 || roomNumber == 204) {

                    

                    

                    Console.WriteLine ("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");

                    Console.Write ("\nNumber of days: ");

                    no_Days = Convert.ToInt32 (Console.ReadLine ());

                    

                    /* Fix later

                    int result = subTotal * roomNumber; */

                    Console.WriteLine ("Subtotal: Sorry po hindi ko na po alam");

                    

                    Console.Write ("Number of Children: ");

                    no_childrens = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.Write ("Number of Adults: ");

                    no_Adult = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.WriteLine ("\n                    PICK DISCOUNT TYPE ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •REGULAR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •SENIOR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                       •SUPER CARD•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                        •HOLIDAYS•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    

                    

                    Console.Write ("\nEnter Discount type: ");

                    discountType = Console.ReadLine ().ToUpper ();

                    

                    Convert.ToDouble (subTotal);

                    

                    

                    switch (discountType) {

                        

                        case "REGULAR":

                            

                            Console.WriteLine ($"Sub Total: {subTotal2+=subTotal}");

                            

                            int i = 1;

                            for (int row = 1; row <= i; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DOUBLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change}");

                            

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i++;

                                }

                            } 

                            

                            

                            

                            

                            

                        break;

                        

                        case "SENIOR":

                            Convert.ToDouble (subTotal2);

                            

                            double discount    = subTotal * 0.2;

                            double discountedPrice = subTotal - discount;

                            Console.WriteLine ($"Subtotal: { discountedPrice}");

                            

                            

                            int i2 = 1;

                            for (int row = 1; row <= i2; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                change =  payment - subTotal;

                                

                                if (subTotal <= payment) {

                                    

                                    change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DOUBLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+200}");

                            

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i2++;

                                }

                            } 

                        break;

                        

                        case "SUPER CARD":

                            

                            double discountedPrice2 = subTotal - (subTotal * 0.05);

                            Console.WriteLine ($"Subtotal: {discountedPrice2}");

                            

                            int i3 = 1;

                            for (int row = 1; row <= i3; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                    change =  payment - subTotal;

                                    

                                    Console.WriteLine ("\n            RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DOUBLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal2}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i3++;

                                }

                            } 

                        break;

                            

                        case "HOLIDAYS":

                            double discountedPrice3 = subTotal - (subTotal * 0.10);

                            Console.WriteLine ($"\nSubtotal: {discountedPrice3}");

                            

                            int i4 = 1;

                            for (int row = 1; row <= i4; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change =  payment - subTotal;

                                     

                                    

                                    Console.WriteLine ("\n            RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DOUBLE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change: {change + 50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i4++;

                                }

                            } 

                            

                            

                            

                            

                        break;

                    } 

                    

                    

                    break;

                }

                

            }

            

            break;

            

            case 3:

            

            roomRate = 8000;

            subTotal  += roomRate;

            Console.WriteLine ($"\nRoom rate: Php {roomRate}\nSub Total: Php {subTotal}");

            

            

            Console.WriteLine ("\n                     PICK ROOM NUMBER");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine ("        |   301   |   302   |   303   |   304   |");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            

            while (true) {    

                Console.Write ("\nEnter Room Number: ");

                roomNumber = Convert.ToInt32 (Console.ReadLine ());

                

                

                

                if (roomNumber == 301 || roomNumber == 302 || roomNumber == 303 || roomNumber == 304) {

                    

                    

                    Console.WriteLine ("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");

                    Console.Write ("\nNumber of days: ");

                    no_Days = Convert.ToInt32 (Console.ReadLine ());

                    

                    /* Fix later

                    int result = subTotal * roomNumber; */

                    Console.WriteLine ("Subtotal: Sorry po hindi ko na po alam");

                    

                    Console.Write ("Number of Children: ");

                    no_childrens = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.Write ("Number of Adults: ");

                    no_Adult = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.WriteLine ("\n                    PICK DISCOUNT TYPE ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •REGULAR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •SENIOR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                       •SUPER CARD•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                        •HOLIDAYS•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    

                    

                    Console.Write ("\nEnter Discount type: ");

                    discountType = Console.ReadLine ().ToUpper ();

                    

                    Convert.ToDouble (subTotal);

                    

                    

                    switch (discountType) {

                        

                        case "REGULAR":

                            

                            Console.WriteLine ($"Sub Total: {subTotal2+=subTotal}");

                            

                            int i = 1;

                            for (int row = 1; row <= i; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DELUXE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change}");

                                    

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i++;

                                }

                            } 

                            

                            

                            

                            

                            

                        break;

                        

                        case "SENIOR":

                            Convert.ToDouble (subTotal2);

                            

                            double discount    = subTotal * 0.2;

                            double discountedPrice = subTotal - discount;

                            Console.WriteLine ($"Subtotal: { discountedPrice}");

                            

                            

                            int i2 = 1;

                            for (int row = 1; row <= i2; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                change =  payment - subTotal;

                                

                                if (subTotal <= payment) {

                                    

                                    change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DELUXE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+200}");

                                    

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i2++;

                                }

                            } 

                        break;

                        

                        case "SUPER CARD":

                            

                            double discountedPrice2 = subTotal - (subTotal * 0.05);

                            Console.WriteLine ($"Subtotal: {discountedPrice2}");

                            

                            int i3 = 1;

                            for (int row = 1; row <= i3; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                    change =  payment - subTotal;

                                    

                                    Console.WriteLine ("\n            RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DELUXE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal2}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i3++;

                                }

                            } 

                        break;

                            

                        case "HOLIDAYS":

                            double discountedPrice3 = subTotal - (subTotal * 0.10);

                            Console.WriteLine ($"\nSubtotal: {discountedPrice3}");

                            

                            int i4 = 1;

                            for (int row = 1; row <= i4; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change =  payment - subTotal;

                                     

                                    

                                    Console.WriteLine ("\n            RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: DELUXE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change: {change + 50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i4++;

                                }

                            } 

                            

                            

                            

                            

                        break;

                    } 

                    

                    

                    break;

                }

                

            }

            

            

            

            break;

            

            case 4:

            

            roomRate = 12000;

            subTotal  += roomRate;

            Console.WriteLine ($"\nRoom rate: Php {roomRate}\nSub Total: Php {subTotal}");

            

            

            Console.WriteLine ("\n                     PICK ROOM NUMBER");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine ("        |   401   |   402   |   403   |   404   |");

            Console.WriteLine ("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            

            while (true) {    

                Console.Write ("\nEnter Room Number: ");

                roomNumber = Convert.ToInt32 (Console.ReadLine ());

                

                

                

                if (roomNumber == 401 || roomNumber == 402 || roomNumber == 403 || roomNumber == 404) {

                    

                    

                    Console.WriteLine ("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");

                    Console.Write ("\nNumber of days: ");

                    no_Days = Convert.ToInt32 (Console.ReadLine ());

                    

                    /* Fix later

                    int result = subTotal * roomNumber; */

                    Console.WriteLine ("Subtotal: Sorry po hindi ko na po alam");

                    

                    Console.Write ("Number of Children: ");

                    no_childrens = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.Write ("Number of Adults: ");

                    no_Adult = Convert.ToInt32 (Console.ReadLine ());

                    

                    Console.WriteLine ("\n                    PICK DISCOUNT TYPE ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •REGULAR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                         •SENIOR•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                       •SUPER CARD•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine ("                        •HOLIDAYS•     ");

                    Console.WriteLine ("                    ~~~~~~~~~~~~~~~~~~");

                    

                    

                    Console.Write ("\nEnter Discount type: ");

                    discountType = Console.ReadLine ().ToUpper ();

                    

                    Convert.ToDouble (subTotal);

                    

                    

                    switch (discountType) {

                        

                        case "REGULAR":

                            

                            Console.WriteLine ($"Sub Total: {subTotal2+=subTotal}");

                            

                            int i = 1;

                            for (int row = 1; row <= i; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SUITE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: (Sorry po sir ulit)");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change}");

                                       

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i++;

                                }

                            } 

                        

                        break;

                        

                        case "SENIOR":

                            Convert.ToDouble (subTotal2);

                            

                            double discount    = subTotal * 0.2;

                            double discountedPrice = subTotal - discount;

                            Console.WriteLine ($"Subtotal: { discountedPrice}");

                            

                            

                            int i2 = 1;

                            for (int row = 1; row <= i2; row++) {

                                Console.Write ("Enter your money, money: ");

                                payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                change =  payment - subTotal;

                                

                                if (subTotal <= payment) {

                                    

                                    change = payment - subTotal;

                                     

                                    Console.WriteLine ("\n                        RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SUITE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal2}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+200}");

                            

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i2++;

                                }

                            } 

                        

                        break;

                        

                        case "SUPER CARD":

                            

                            double discountedPrice2 = subTotal - (subTotal * 0.05);

                            Console.WriteLine ($"Subtotal: {discountedPrice2}");

                            

                            int i3 = 1;

                            for (int row = 1; row <= i3; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                    change =  payment - subTotal;

                                    

                                    Console.WriteLine ("\n            RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SUITE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal2}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change {change+50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i3++;

                                }

                            } 

                        break;

                            

                        case "HOLIDAYS":

                            double discountedPrice3 = subTotal - (subTotal * 0.10);

                            Console.WriteLine ($"\nSubtotal: {discountedPrice3}");

                            

                            int i4 = 1;

                            for (int row = 1; row <= i4; row++) {

                                Console.Write ("Enter your money, money: ");

                                 payment = Convert.ToInt32 (Console.ReadLine ());

                                

                                

                                if (subTotal <= payment) {

                                    

                                     change =  payment - subTotal;

                                     

                                    

                                    Console.WriteLine ("\n            RECEIPT ");

                                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                    Console.WriteLine ($"Guest name: {guestName}");

                                    Console.WriteLine ("Room Type: SUITE");

                                    Console.WriteLine ($"Room Rate: {roomRate}");

                                    Console.WriteLine ($"Room Number: {roomNumber}");

                                    Console.WriteLine ($"Number of Days: {no_Days}");

                                    Console.WriteLine ($"Additional Rate per day: 200");

                                    Console.WriteLine ($"Number of Children: {no_childrens}");

                                    Console.WriteLine ($"Number of Adults: {no_Adult}");

                                    Console.WriteLine ($"SubTotal: {subTotal}");

                                    Console.WriteLine ($"Discount Type: {discountType}");

                                    Console.WriteLine ($"Discount Total: {subTotal}");

                                    Console.WriteLine ($"payment: {payment}");

                                    Console.WriteLine ($"change: {change + 50}");

                                    

                                } else {

                                    Console.WriteLine ("The payment you entered is insufficient!");

                                    Console.WriteLine ("             Please try again!");

                                    i4++;

                                }

                            } 

                            

                            

                            

                            

                        break;

                    } 

                    

                    

                    break;

                }

                

            }

                

            

            break;

        }

        Console.WriteLine ();

        Console.WriteLine ();

        Console.WriteLine ();

        Console.WriteLine ();

        Console.WriteLine ();

        

        Console.WriteLine ("ICT-6 GROUP 3");

        Console.WriteLine ("Programmer: (Joshua C. Ruiz)");

        Console.WriteLine ("Mga tumulong: Joel Cruz, Steven Mucho");

        Console.WriteLine ("Mga pabigat: Jedrick Tabutol, Kris Lawrence locanas, jeremy ivan maduro, james Philip ramilo");

        

        // ang sarap ilagay sa array sir yung mga pabigat HAHAHA

        

        

        

    }    

        

}
