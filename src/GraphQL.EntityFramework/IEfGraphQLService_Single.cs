﻿using System;
using System.Collections.Generic;
using System.Linq;
using GraphQL.Types;

namespace GraphQL.EntityFramework
{
    public partial interface IEfGraphQLService
    {
        FieldType AddSingleField<TReturn>(
            ObjectGraphType graph,
            string name,
            Type graphType,
            Func<ResolveFieldContext<object>, IQueryable<TReturn>> resolve,
            IEnumerable<QueryArgument> arguments = null)
            where TReturn : class;

        FieldType AddSingleField<TSource, TReturn>(
            ObjectGraphType<TSource> graph,
            string name,
            Type graphType,
            Func<ResolveFieldContext<TSource>, IQueryable<TReturn>> resolve,
            IEnumerable<QueryArgument> arguments = null)
            where TReturn : class;

        FieldType AddSingleField<TSource, TReturn>(
            ObjectGraphType graph,
            string name,
            Type graphType,
            Func<ResolveFieldContext<TSource>, IQueryable<TReturn>> resolve,
            IEnumerable<QueryArgument> arguments = null)
            where TReturn : class;

        FieldType AddSingleField<TGraph, TReturn>(
            ObjectGraphType graph,
            string name,
            Func<ResolveFieldContext<object>, IQueryable<TReturn>> resolve,
            IEnumerable<QueryArgument> arguments = null)
            where TGraph : ObjectGraphType<TReturn>, IGraphType
            where TReturn : class;

        FieldType AddSingleField<TSource, TGraph, TReturn>(
            ObjectGraphType graph,
            string name,
            Func<ResolveFieldContext<TSource>, IQueryable<TReturn>> resolve,
            IEnumerable<QueryArgument> arguments = null)
            where TGraph : ObjectGraphType<TReturn>, IGraphType
            where TReturn : class;

        FieldType AddSingleField<TSource, TGraph, TReturn>(
            ObjectGraphType<TSource> graph,
            string name,
            Func<ResolveFieldContext<TSource>, IQueryable<TReturn>> resolve,
            IEnumerable<QueryArgument> arguments = null)
            where TGraph : ObjectGraphType<TReturn>, IGraphType
            where TReturn : class;
    }
}