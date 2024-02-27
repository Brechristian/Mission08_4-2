using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Mission08_4_2.Models
{

    // need to include required columns
    //Task, Quadrant
    // category and completed are not technically "Required", however they are dropdowns so they will always be included
    // 

    public interface IToDoListRepository
    {

    }
        /*
    {
        List<InserttableNameHere> insertName { get; }

        public void AddtableName(TableName name);
    }
        */

   
}
   