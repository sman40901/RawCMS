﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************

namespace RawCMS.Plugins.ApiGateway.Classes.Settings
{
    public class Node
    {
        /// <summary>
        /// Terget Host value
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Target Port value
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Target scheme value
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// Enable target node
        /// </summary>
        public bool Enable { get; set; }

        public Node()
        {
            Enable = true;
        }
    }
}