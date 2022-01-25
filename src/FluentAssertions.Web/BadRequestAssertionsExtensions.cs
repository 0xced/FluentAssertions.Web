﻿using FluentAssertions.Web;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace FluentAssertions
{
    /// <summary>
    /// Contains extension methods for custom assertions in unit tests related to <see cref="BadRequestAssertions"/>.
    /// </summary>
    [DebuggerNonUserCode]
    public static class BadRequestAssertionsExtensions
    {
        /// <summary>
        /// Asserts that a Bad Request HTTP response content contains an error message identifiable by an expected field name and a wildcard error text.
        /// </summary>
        /// <remarks>
        /// This assertion considers the HTTP response content a JSON generated by the ASP.NET Core 3.0 framework or less
        /// </remarks>
        /// <param name="expectedErrorField">
        /// The expected field name.
        /// </param>
        /// <param name="expectedWildcardErrorMessage">
        /// The wildcard pattern with which the error field associated error message is matched, where * and ? have special meanings.
        /// </param>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        /// Zero or more objects to format using the placeholders in <see paramref="because" />.
        /// </param>
        public static AndConstraint<BadRequestAssertions> HaveError(
#pragma warning disable 1573
            this Primitives.HttpResponseMessageAssertions<Primitives.HttpResponseMessageAssertions> parent,
#pragma warning restore 1573
            string expectedErrorField, string expectedWildcardErrorMessage,
            string because = "", params object[] becauseArgs)
            => new BadRequestAssertions(parent.Subject).HaveError(expectedErrorField, expectedWildcardErrorMessage, because, becauseArgs);

        /// <summary>
        /// Asserts that a Bad Request HTTP response content contains only a single error message identifiable by an expected field name and a wildcard error text.
        /// </summary>
        /// <remarks>
        /// This assertion considers the HTTP response content a JSON generated by the ASP.NET Core 3.0 framework or less
        /// </remarks>
        /// <param name="expectedErrorField">
        /// The expected field name.
        /// </param>
        /// <param name="expectedWildcardErrorMessage">
        /// The wildcard pattern with which the error field associated error message is matched, where * and ? have special meanings.
        /// </param>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        /// Zero or more objects to format using the placeholders in <see paramref="because" />.
        /// </param>
        public static AndConstraint<BadRequestAssertions> OnlyHaveError(
#pragma warning disable 1573
            this Primitives.HttpResponseMessageAssertions<Primitives.HttpResponseMessageAssertions> parent,
#pragma warning restore 1573
            string expectedErrorField, string expectedWildcardErrorMessage,
            string because = "", params object[] becauseArgs)
            => new BadRequestAssertions(parent.Subject).OnlyHaveError(expectedErrorField, expectedWildcardErrorMessage, because, becauseArgs);

        /// <summary>
        /// Asserts that a Bad Request HTTP response content does not contain an error message identifiable by an expected field name.
        /// </summary>
        /// <remarks>
        /// This assertion considers the HTTP response content a JSON generated by the ASP.NET Core 3.0 framework or less
        /// </remarks>
        /// <param name="expectedErrorField">
        /// The expected field name.
        /// </param>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        /// Zero or more objects to format using the placeholders in <see paramref="because" />.
        /// </param>
        public static AndConstraint<BadRequestAssertions> NotHaveError(
#pragma warning disable 1573
            this Primitives.HttpResponseMessageAssertions<Primitives.HttpResponseMessageAssertions> parent,
#pragma warning restore 1573
            string expectedErrorField, string because = "", params object[] becauseArgs)
            => new BadRequestAssertions(parent.Subject).NotHaveError(expectedErrorField, because, becauseArgs);

        /// <summary>
        /// Asserts that a Bad Request HTTP response content contains an error message identifiable by an wildcard error text.
        /// </summary>
        /// <param name="expectedWildcardErrorMessage">
        /// The wildcard pattern with which the error field associated error message is matched, where * and ? have special meanings.
        /// </param>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        /// Zero or more objects to format using the placeholders in <see paramref="because" />.
        /// </param>
        public static AndConstraint<BadRequestAssertions> HaveErrorMessage(
#pragma warning disable 1573
            this Primitives.HttpResponseMessageAssertions<Primitives.HttpResponseMessageAssertions> parent,
#pragma warning restore 1573
            string expectedWildcardErrorMessage,
            string because = "", params object[] becauseArgs)
            => new BadRequestAssertions(parent.Subject).HaveErrorMessage(expectedWildcardErrorMessage, because, becauseArgs);
    }
}