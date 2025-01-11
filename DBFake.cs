using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lab 1
/// Author(s): Will Otterbein
/// Date: January 10 2024
/// Revision: 1
/// </summary>
namespace COMP3951_Lab1_WillOtterbein
{
    /// <summary>
    /// Class represents a fake database where records can be added
    /// </summary>
    public class DBFake
    {
        /// <summary>
        /// DBRecord class is the template for records in the fake database.
        /// </summary>
        public class DBRecord
        {
            private static int count = 0;
            private string firstName, lastName;

            /// <summary>
            /// Public auto-implemented property.
            /// </summary>
            public string MiddleName { get; set; }
            /// <summary>
            /// Public auto-implemented property.
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// FirstName property implementation.
            /// Contains validation
            /// </summary>
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value))
                        firstName = value;
                }
            }
            /// <summary>
            /// LastName property implementation.
            /// Contains validation
            /// </summary>
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    if (!String.IsNullOrEmpty(value))
                        lastName = value;
                }
            }

            /// <summary>
            /// Constructor for the DBRecord object.
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            /// <param name="middleName"></param>
            public DBRecord(string fName, string lName, string mName)
            {
                FirstName = fName;
                LastName = lName;
                MiddleName = mName;
                ID = count++;
            }

            /// <summary>
            /// Returns a string representing the DBRecord object.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{ID}\t{FirstName}\t{LastName}\t{MiddleName}";
            }
        }

        static readonly Hashtable records = new Hashtable();

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
        public static DBRecord AddRecordToDB(string firstName, string lastName, string middleName)
        {
            DBRecord nRec = new DBRecord(firstName, lastName, middleName);
            records.Add(nRec.ID, nRec);
            return nRec;
        }

        /// <summary>
        /// Returns the records of the database.
        /// </summary>
        /// <returns></returns>
        public static Hashtable GetRecords() { return records; }
    }
}
