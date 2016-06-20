﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using Xunit;

namespace Cake.Core.Tests.Unit
{
    public sealed class TaskTeardownContextTests
    {
        public sealed class TheConstructor
        {
            [Fact]
            public void Should_Throw_If_Task_Is_Null()
            {
                // Given, When
                var result = Record.Exception(() => new TaskSetupContext(null));

                // Then
                Assert.IsArgumentNullException(result, "task");
            }
        }
    }
}
