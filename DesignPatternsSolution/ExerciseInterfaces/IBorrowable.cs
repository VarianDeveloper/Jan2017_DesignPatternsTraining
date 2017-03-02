using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseInterfaces
{
    public interface IBorrowable
    {
        int BorrowOne();
        int Borrow(int numberOfCopiesToBorrow);
    }
}
