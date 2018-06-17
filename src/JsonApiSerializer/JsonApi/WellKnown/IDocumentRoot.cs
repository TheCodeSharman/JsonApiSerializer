﻿namespace JsonApiSerializer.JsonApi.WellKnown
{
    /// <summary>
    /// Represents any class that is a document root. Document root classes are serialized and deserialized specially.
    /// </summary>
    /// <typeparam name="TData">The type of the data.</typeparam>
    public interface IDocumentRoot<TData>
    {
        TData Data { get; set; }
    }
}
