﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using ClientModel.Tests.Mocks;
using NUnit.Framework;
using System.ClientModel.Primitives;

namespace System.ClientModel.Tests.Message;

public class PipelineMessageTests
{
    [Test]
    public void CanSetAndGetMessageProperties()
    {
        ClientPipelineOptions options = new ClientPipelineOptions()
        {
            Transport = new ObservableTransport("MockTransport")
        };

        ClientPipeline pipeline = ClientPipeline.Create(options);
        PipelineMessage message = pipeline.CreateMessage();

        message.SetProperty(GetType(), "MockProperty");

        Assert.IsTrue(message.TryGetProperty(GetType(), out object? property));
        Assert.AreEqual("MockProperty", property);
    }

    [Test]
    public void TryGetPropertyReturnsFalseIfNotExist()
    {
        ClientPipelineOptions options = new ClientPipelineOptions()
        {
            Transport = new ObservableTransport("MockTransport")
        };

        ClientPipeline pipeline = ClientPipeline.Create(options);
        PipelineMessage message = pipeline.CreateMessage();

        Assert.False(message.TryGetProperty(GetType(), out _));
    }

    [Test]
    public void TryGetPropertyReturnsValueIfSet()
    {
        ClientPipelineOptions options = new ClientPipelineOptions()
        {
            Transport = new ObservableTransport("MockTransport")
        };

        ClientPipeline pipeline = ClientPipeline.Create(options);
        PipelineMessage message = pipeline.CreateMessage();

        message.SetProperty(GetType(), "value");

        Assert.True(message.TryGetProperty(GetType(), out object? value));
        Assert.AreEqual("value", value);
    }

    [Test]
    public void TryGetTypeKeyedPropertyReturnsCorrectValues()
    {
        ClientPipelineOptions options = new ClientPipelineOptions()
        {
            Transport = new ObservableTransport("MockTransport")
        };

        ClientPipeline pipeline = ClientPipeline.Create(options);
        PipelineMessage message = pipeline.CreateMessage();

        int readLoops = 10;
        var t3 = new T3() { Value = 1234 };
        message.SetProperty(typeof(T1), new T1() { Value = 1111 });
        message.SetProperty(typeof(T2), new T2() { Value = 2222 });
        message.SetProperty(typeof(T3), new T3() { Value = 3333 });
        message.SetProperty(typeof(T4), new T4() { Value = 4444 });

        message.TryGetProperty(typeof(T1), out var value);
        Assert.AreEqual(1111, ((T1)value!).Value);
        message.TryGetProperty(typeof(T2), out value);
        Assert.AreEqual(2222, ((T2)value!).Value);
        message.TryGetProperty(typeof(T3), out value);
        Assert.AreEqual(3333, ((T3)value!).Value);
        message.TryGetProperty(typeof(T4), out value);
        Assert.AreEqual(4444, ((T4)value!).Value);

        for (int i = 0; i < readLoops; i++)
        {
            t3.Value = i;
            message.SetProperty(typeof(T3), t3);
            message.TryGetProperty(typeof(T3), out value);
            Assert.AreEqual(i, ((T3)value!).Value);
        }

        message.TryGetProperty(typeof(T4), out value);
        Assert.AreEqual(4444, ((T4)value!).Value);
    }

    #region Helpers
    private struct T1
    {
        public int Value { get; set; }
    }

    private struct T2
    {
        public int Value { get; set; }
    }

    private struct T3
    {
        public int Value { get; set; }
    }

    private struct T4
    {
        public int Value { get; set; }
    }

    private struct T5
    {
        public int Value { get; set; }
    }
    #endregion
}
