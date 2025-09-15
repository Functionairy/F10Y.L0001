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
        N002.Result<T> Failure<T>(Exception exception)
            => new N002.Result<T>
            {
                Success = false,
                Value = default,
                Exception = exception,
            };

        IResultOperator<TInput, TOutput> For<TInput, TOutput>()
            => ResultOperator<TInput, TOutput>.Instance;

        N002.Result<T> Success<T>(T value)
            => new N002.Result<T>
            {
                Success = true,
                Value = value
            };

        IEnumerable<string> Get_Lines_ForOutput<T>(
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

        IEnumerable<string> Get_Lines_ForOutput<T>(
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

        bool Is_Success<T>(N002.IResult<T> result)
            => result.Success;

        bool Is_NotSuccess<T>(N002.IResult<T> result)
            => !this.Is_Success(result);
    }


    [FunctionsMarker]
    public partial interface IResultOperator<TInput, TOutput>
    {
        N006.Result<TInput, TOutput> From(
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

        N006.Result<TInput, TOutput> Success(
            TInput input,
            TOutput output)
            => this.From(
                Instances.Booleans.Success,
                input,
                output,
                Instances.Exceptions.None);

        N006.Result<TInput, TOutput> Failure(
            TInput input,
            Exception exception)
            => this.From(
                Instances.Booleans.Failure,
                input,
                Instances.DefaultOperator.For<TOutput>().Value,
                Instances.Exceptions.None);
    }
}
