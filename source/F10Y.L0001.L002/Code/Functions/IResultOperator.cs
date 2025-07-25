using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.T0002;


namespace F10Y.L0001.L002
{
    [FunctionsMarker]
    public partial interface IResultOperator
    {
        public IResultOperator<TInput, TOutput> For<TInput, TOutput>()
            => ResultOperator<TInput, TOutput>.Instance;

        public IEnumerable<string> Get_Lines_ForOutput<T>(
            N003.Result<
            IEnumerable<string>,
            N002.IFailed<T>
            > result)
        {
            var output = result.Is_Success
                ? result.Success
                : result.Failure.Message_Lines
                ;

            return output;
        }

        public IEnumerable<string> Get_Lines_ForOutput<T>(
            N003.Result<
            IEnumerable<string>,
            N002.IFailed<T>[]
            > result)
        {
            var output = result.Success
                .Append(result.Failure
                    .SelectMany(failure => failure.Message_Lines)
                )
                ;

            return output;
        }
    }


    [FunctionsMarker]
    public partial interface IResultOperator<TInput, TOutput>
    {
        public N006.Result<TInput, TOutput> From(
            bool success,
            TInput input,
            TOutput output,
            Exception exception)
            => new N006.Result<TInput, TOutput>
            {
                Exception = exception,
                Input = input,
                Output = output,
                Success = success,
            };

        public N006.Result<TInput, TOutput> Success(
            TInput input,
            TOutput output)
            => this.From(
                Instances.Booleans.Success,
                input,
                output,
                Instances.Exceptions.None);

        public N006.Result<TInput, TOutput> Failure(
            TInput input,
            Exception exception)
            => this.From(
                Instances.Booleans.Failure,
                input,
                Instances.DefaultOperator.For<TOutput>().Value,
                Instances.Exceptions.None);
    }
}
