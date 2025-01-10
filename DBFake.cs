using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3951_Lab1_WillOtterbein
{
    /// <summary>
    /// Class represents a fake database where records can be added
    /// </summary>
    public static class DBFake
    {
        static readonly Hashtable records = new Hashtable();

        /// <summary>
        /// DBRecord struct is record for the fake database.
        /// </summary>
        struct DBRecord
        {
            static int count = 0;
            public int ID { get; }
            public String FirstName { get; set; }
            public String MiddleName { get; set; }
            public String LastName { get; set; }

            /// <summary>
            /// Constructor for the DBRecord struct.
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            /// <param name="middleName"></param>
            public DBRecord(String firstName, String lastName, String middleName = "")
            {
                FirstName = firstName;
                MiddleName = middleName;
                LastName = lastName;
                ID = count++;
            }
            /// <summary>
            /// Returns a string representing the DBRecord struct.
            /// </summary>
            /// <returns></returns>
            public override string ToString() 
            {
                return $"{ID}\t{FirstName}\t{LastName}\t{MiddleName}";
            }
        };

        /// <summary>
        /// Show the records in the DBFake list.
        /// </summary>
        private static void PrintRecords()
        {
            Console.WriteLine(">>>PRINTING_DB_records");
            // Iterate over the hastable and show the objects
            // Should use the ToString method from DBRecord
            Console.WriteLine(">>>>>>ID\tFName\tLName\tMName");
            for (var rec = records.GetEnumerator(); rec.MoveNext();)
                Console.WriteLine($">>>>>>{rec.Value}");
        }

        /// <summary>
        /// Creates DBRecord and adds to Hashtable of records.
        /// 
        /// ID of record is the key.
        /// Value is the DBRecord itself.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="middleName"></param>
        public static void AddRecordToDB(String firstName, String lastName, String middleName)
        {
            Console.WriteLine($">>>NEW REC\n>>>>>>{firstName}, {lastName}, {middleName}");
            DBRecord nRec = new DBRecord(firstName, lastName, middleName);
            records.Add(nRec.ID, nRec);
            PrintRecords();
        }

        /// <summary>
        /// Returns the records of the database.
        /// </summary>
        /// <returns></returns>
        public static Hashtable GetRecords() { return records; }
    }
}
