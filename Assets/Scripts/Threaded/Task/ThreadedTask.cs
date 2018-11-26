﻿using System;
using System.Threading;

namespace App.Threaded.Task {

    public abstract class ThreadedTask<Params, Progress, Result> {

        protected Action<Progress> _progressCallback;

        public TaskStatus Status { get; private set; } = TaskStatus.NotStarted;

        public ThreadedTask(params Params[] args) {

        }

        public void Start(Action<Result> callback = null) {
            if (Status >= TaskStatus.Started) {
                // TODO Throw exception.
                return;
            }

            Status = TaskStatus.Started;

            ThreadPool.QueueUserWorkItem((state) => {
                Result result = Task();
                callback?.Invoke(result);
                Status = TaskStatus.Completed;
            });
        }

        public abstract Progress GetProgress();

        /// <summary>
        ///     Registers a callback function that is called when progress is updated.
        ///     It is up to the implementing classes to manually call the callback
        ///     function when it updates the progress.
        /// </summary>
        public void OnProgressChange(Action<Progress> callback) {
            _progressCallback = callback;
        }

        protected abstract Result Task();

        public static bool operator true(ThreadedTask<Params, Progress, Result> o) {
            return o != null;
        }

        public static bool operator false(ThreadedTask<Params, Progress, Result> o) {
            return o == null;
        }

        public static bool operator !(ThreadedTask<Params, Progress, Result> o) {
            return o ? false : true;
        }

    }

}
