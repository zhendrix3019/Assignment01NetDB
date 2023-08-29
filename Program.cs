 string csvFilePath = "Tickets.csv";

        while (true)
        {
            Console.WriteLine("Enter Ticket ID:");
            int ticketId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Summary:");
            string summary = Console.ReadLine();

            Console.WriteLine("Enter Status:");
            string status = Console.ReadLine();

            Console.WriteLine("Enter Priority:");
            string priority = Console.ReadLine();

            Console.WriteLine("Enter Submitter:");
            string submitter = Console.ReadLine();

            Console.WriteLine("Enter Assigned:");
            string assigned = Console.ReadLine();

            Console.WriteLine("Enter Watching (separated by '|'):");
            string watching = Console.ReadLine();

            // Create CSV formatted record
            string newRecord = $"{ticketId},{summary},{status},{priority},{submitter},{assigned},{watching}";

            // Append the record to the CSV file
            using (StreamWriter sw = File.AppendText(csvFilePath))
            {
                sw.WriteLine(newRecord);
            }

            Console.WriteLine("Record added successfully!");
            
            Console.WriteLine("Do you want to add another record? (yes/no)");
            string anotherRecord = Console.ReadLine().ToLower();
            if (anotherRecord != "yes")
                break;}