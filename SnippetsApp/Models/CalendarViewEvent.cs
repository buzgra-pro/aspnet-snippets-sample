// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

// <CalendarViewEventSnippet>
using Microsoft.Graph;
using System;

namespace SnippetsApp.Models
{
    public class CalendarViewEvent
    {
        public string Subject { get; private set; }
        public string Organizer { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public CalendarViewEvent(Event graphEvent)
        {
            Subject = graphEvent.Subject;
            Organizer = graphEvent.Organizer.EmailAddress.Name;
            Start = DateTime.Parse(graphEvent.Start.DateTime);
            End = DateTime.Parse(graphEvent.End.DateTime);
        }
    }
}
// </CalendarViewEventSnippet>
