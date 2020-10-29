using InstaSharper.Classes;
using System;
using System.Threading.Tasks;

namespace Extensions
{
    public static class AwaitHelper
    {
        public static IResult<T> Waiting<T>(Func<Task<IResult<T>>> request)
        {
            var result = Task.Run(async () => { return await request(); }).Result;
            return result;
        }
    }
}
