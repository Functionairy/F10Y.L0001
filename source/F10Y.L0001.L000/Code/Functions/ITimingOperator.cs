using System;
using System.Diagnostics;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface ITimingOperator
    {
        public Stopwatch Get_StartedStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            return stopwatch;
        }

        public TimeSpan Get_Duration(Stopwatch stopwatch)
        {
            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public TimeSpan Measure_Duration_OfAction(Action action)
        {
            var stopwatch = this.Get_StartedStopwatch();

            action();

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public async Task<TimeSpan> Measure_Duration(Task task)
        {
            var stopwatch = this.Get_StartedStopwatch();

            await task;

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public async Task<TimeSpan> Measure_Duration(Func<Task> action)
        {
            var stopwatch = this.Get_StartedStopwatch();

            await action();

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public TimeSpan MeasureDuration(Action action)
        {
            var stopwatch = this.Get_StartedStopwatch();

            action();

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public TOut MeasureDuration<TOut>(
            Func<TOut> function,
            out TimeSpan duration)
        {
            var stopwatch = this.Get_StartedStopwatch();

            var output = function();

            stopwatch.Stop();

            duration = stopwatch.Elapsed;

            return output;
        }

        public TimeSpan In_TimingContext(
            Action action,
            Action<TimeSpan> durationConsumer)
        {
            var duration = this.In_TimingContext(action);

            durationConsumer(duration);

            return duration;
        }

        public TOut In_TimingContext_ForFunction<TOut>(
            Func<TOut> function,
            out TimeSpan duration)
        {
            var output = this.MeasureDuration(
                function,
                out duration);

            return output;
        }

        public TimeSpan In_TimingContext(Action action)
            => this.MeasureDuration(action);

        public Task<TimeSpan> In_TimingContext(Func<Task> action)
            => this.Measure_Duration(action);
    }
}
