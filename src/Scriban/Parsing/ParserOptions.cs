// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
namespace Scriban.Parsing
{
    /// <summary>
    /// Defines the options used when parsing a template.
    /// </summary>
    public struct ParserOptions
    {
        /// <summary>
        /// Sets the depth limit of nested statements (e.g nested if/else) to disallow deep/potential stack-overflow exploits. Default is null, so there is no limit.
        /// </summary>
        public int? StatementDepthLimit { get; set; }
    }
}