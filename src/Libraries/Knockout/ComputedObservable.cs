// ComputedObservable.cs
// Script#/Libraries/Knockout
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace KnockoutApi {

    /// <summary>
    /// Represents an object containing a computed value based on other observable values.
    /// </summary>
    /// <typeparam name="T">The type of the contained value.</typeparam>
    [ScriptImport]
    [ScriptIgnoreNamespace]
    public sealed class ComputedObservable<T> {

        private ComputedObservable() {
        }

        /// <summary>
        /// Gets the current computed value.
        /// </summary>
        /// <returns>The current value.</returns>
        [ScriptName("")]
        public T GetValue() {
            return default(T);
        }

        /// <summary>
        /// Disposes this Subscribable
        /// </summary>
        public void Dispose() {
        }

        /// <summary>
        /// For computed observables, we throttle *evaluations* so that, no matter how fast its dependencies
        /// notify updates, the target doesn't re-evaluate (and hence doesn't notify) faster than a certain rate
        /// For writable targets (observables, or writable dependent observables), we throttle *writes*
        /// so the target cannot change value synchronously or faster than a certain rate
        /// </summary>
        /// <param name="options"></param>
        /// <returns>The current instance.</returns>
        public ComputedObservable<T> Extend(Dictionary options) {
            return null;
        }

        /// <summary>
        /// Get Dependencies Count
        /// </summary>
        /// <returns>Returns the Number of Dependencies</returns>
        public int GetDependenciesCount() {
            return 0;
        }

        /// <summary>
        /// Sets the Value and Notifies all of the Subscribers
        /// </summary>
        /// <param name="value">The Value to be Set</param>
        public void NotifySubscribers(T value) {
        }

        /// <summary>
        /// Sets the Value and Notifies all of the Subscribers for the Specified Event
        /// </summary>
        /// <param name="value">The Value to be Set</param>
        /// <param name="eventName">[Optional] Event Name</param>
        public void NotifySubscribers(T value, string eventName) {
        }

        /// <summary>
        /// Subscribes to change notifications raised when the value changes.
        /// </summary>
        /// <param name="changeCallback">The callback to invoke.</param>
        /// <returns>A subscription cookie that can be disposed to unsubscribe.</returns>
        public IDisposable Subscribe(Action<T> changeCallback) {
            return null;
        }
    }
}
