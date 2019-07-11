using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMethod
{
    class  DataBase <T>
    {
        public bool Add(T tableType) {

            bool result = false;

            using(var db = new Model.LibData())
            {
                if(tableType is Model.Clients)
                {
                    var table = tableType as Model.Clients;
                    db.Clients.Add(table);
                }
                else if(tableType is Model.Books)
                {
                    var table = tableType as Model.Books;
                    db.Books.Add(table);
                }
                else if(tableType is Model.Author)
                {
                    var table = tableType as Model.Author;
                    db.Author.Add(table);
                }


                if (db.SaveChanges() != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            if (result == true) { return true; }
            return false;
        }
    }
}
