﻿namespace Zinnia.Data.Collection.List
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;
    using System.Collections.Generic;
    using Malimbe.XmlDocumentationAttribute;
    using Malimbe.PropertySerializationAttribute;
    using Zinnia.Data.Type;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// Allows observing changes to a <see cref="List{T}"/> of <see cref="SerializableType"/>s.
    /// </summary>
    public class SerializableTypeBehaviourObservableList : ObservableList<SerializableType, SerializableTypeBehaviourObservableList.UnityEvent>
    {
        /// <summary>
        /// The collection to observe changes of.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, TypePicker(typeof(Behaviour))]
        protected override List<SerializableType> Elements { get; set; } = new List<SerializableType>();

        /// <summary>
        /// Defines the event with the <see cref="SerializableType"/>.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<SerializableType>
        {
        }
    }
}