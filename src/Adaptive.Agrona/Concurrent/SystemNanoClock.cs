﻿/*
 * Copyright 2014 - 2017 Adaptive Financial Consulting Ltd
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Diagnostics;

namespace Adaptive.Agrona.Concurrent
{
    public class SystemNanoClock : INanoClock
    {
        private readonly Stopwatch _stopwatch;

        public SystemNanoClock()
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public long NanoTime()
        {
            return _stopwatch.ElapsedMilliseconds*1000*1000;
        }
    }
}