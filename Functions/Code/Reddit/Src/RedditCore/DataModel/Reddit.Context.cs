﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RedditCore.DataModel
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class RedditEntities : DbContext
{
    public RedditEntities()
        : base("name=RedditEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<UserDefinedEntity> UserDefinedEntities { get; set; }

    public virtual DbSet<UserDefinedEntityDefinition> UserDefinedEntityDefinitions { get; set; }

    public virtual DbSet<EmbeddedUrl> EmbeddedUrls { get; set; }

    public virtual DbSet<PostCommentCount> PostCommentCounts { get; set; }


    public virtual int InsertSubreddit(Nullable<long> newDocId, string content, Nullable<int> ups, Nullable<int> downs, Nullable<int> gilded, string author, string subreddit, string title)
    {

        var newDocIdParameter = newDocId.HasValue ?
            new ObjectParameter("NewDocId", newDocId) :
            new ObjectParameter("NewDocId", typeof(long));


        var contentParameter = content != null ?
            new ObjectParameter("content", content) :
            new ObjectParameter("content", typeof(string));


        var upsParameter = ups.HasValue ?
            new ObjectParameter("ups", ups) :
            new ObjectParameter("ups", typeof(int));


        var downsParameter = downs.HasValue ?
            new ObjectParameter("downs", downs) :
            new ObjectParameter("downs", typeof(int));


        var gildedParameter = gilded.HasValue ?
            new ObjectParameter("gilded", gilded) :
            new ObjectParameter("gilded", typeof(int));


        var authorParameter = author != null ?
            new ObjectParameter("author", author) :
            new ObjectParameter("author", typeof(string));


        var subredditParameter = subreddit != null ?
            new ObjectParameter("subreddit", subreddit) :
            new ObjectParameter("subreddit", typeof(string));


        var titleParameter = title != null ?
            new ObjectParameter("title", title) :
            new ObjectParameter("title", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSubreddit", newDocIdParameter, contentParameter, upsParameter, downsParameter, gildedParameter, authorParameter, subredditParameter, titleParameter);
    }


    public virtual int InsertComment(Nullable<long> newDocId, string content, Nullable<int> ups, Nullable<int> downs, Nullable<int> gilded, string author, string subreddit, string parentId)
    {

        var newDocIdParameter = newDocId.HasValue ?
            new ObjectParameter("NewDocId", newDocId) :
            new ObjectParameter("NewDocId", typeof(long));


        var contentParameter = content != null ?
            new ObjectParameter("content", content) :
            new ObjectParameter("content", typeof(string));


        var upsParameter = ups.HasValue ?
            new ObjectParameter("ups", ups) :
            new ObjectParameter("ups", typeof(int));


        var downsParameter = downs.HasValue ?
            new ObjectParameter("downs", downs) :
            new ObjectParameter("downs", typeof(int));


        var gildedParameter = gilded.HasValue ?
            new ObjectParameter("gilded", gilded) :
            new ObjectParameter("gilded", typeof(int));


        var authorParameter = author != null ?
            new ObjectParameter("author", author) :
            new ObjectParameter("author", typeof(string));


        var subredditParameter = subreddit != null ?
            new ObjectParameter("subreddit", subreddit) :
            new ObjectParameter("subreddit", typeof(string));


        var parentIdParameter = parentId != null ?
            new ObjectParameter("parentId", parentId) :
            new ObjectParameter("parentId", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertComment", newDocIdParameter, contentParameter, upsParameter, downsParameter, gildedParameter, authorParameter, subredditParameter, parentIdParameter);
    }


    public virtual int InsertSubreddit1(Nullable<long> newDocId, string content, Nullable<int> ups, Nullable<int> downs, Nullable<int> gilded, string author, string subreddit, string title)
    {

        var newDocIdParameter = newDocId.HasValue ?
            new ObjectParameter("NewDocId", newDocId) :
            new ObjectParameter("NewDocId", typeof(long));


        var contentParameter = content != null ?
            new ObjectParameter("content", content) :
            new ObjectParameter("content", typeof(string));


        var upsParameter = ups.HasValue ?
            new ObjectParameter("ups", ups) :
            new ObjectParameter("ups", typeof(int));


        var downsParameter = downs.HasValue ?
            new ObjectParameter("downs", downs) :
            new ObjectParameter("downs", typeof(int));


        var gildedParameter = gilded.HasValue ?
            new ObjectParameter("gilded", gilded) :
            new ObjectParameter("gilded", typeof(int));


        var authorParameter = author != null ?
            new ObjectParameter("author", author) :
            new ObjectParameter("author", typeof(string));


        var subredditParameter = subreddit != null ?
            new ObjectParameter("subreddit", subreddit) :
            new ObjectParameter("subreddit", typeof(string));


        var titleParameter = title != null ?
            new ObjectParameter("title", title) :
            new ObjectParameter("title", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSubreddit1", newDocIdParameter, contentParameter, upsParameter, downsParameter, gildedParameter, authorParameter, subredditParameter, titleParameter);
    }


    public virtual int InsertComment1(string newDocId, string content, Nullable<int> score, Nullable<double> controversiality, Nullable<int> gilded, string author, string subreddit, Nullable<System.DateTime> publishedTimestamp, Nullable<System.DateTime> publishedMonthPrecision, Nullable<System.DateTime> publishedWeekPrecision, Nullable<System.DateTime> publishedDayPrecision, Nullable<System.DateTime> publishedHourPrecision, Nullable<System.DateTime> publishedMinutePrecision, Nullable<System.DateTime> ingestedTimestamp, string url, string parentId, string postId, string parentUrl, string postUrl)
    {

        var newDocIdParameter = newDocId != null ?
            new ObjectParameter("NewDocId", newDocId) :
            new ObjectParameter("NewDocId", typeof(string));


        var contentParameter = content != null ?
            new ObjectParameter("content", content) :
            new ObjectParameter("content", typeof(string));


        var scoreParameter = score.HasValue ?
            new ObjectParameter("score", score) :
            new ObjectParameter("score", typeof(int));


        var controversialityParameter = controversiality.HasValue ?
            new ObjectParameter("controversiality", controversiality) :
            new ObjectParameter("controversiality", typeof(double));


        var gildedParameter = gilded.HasValue ?
            new ObjectParameter("gilded", gilded) :
            new ObjectParameter("gilded", typeof(int));


        var authorParameter = author != null ?
            new ObjectParameter("author", author) :
            new ObjectParameter("author", typeof(string));


        var subredditParameter = subreddit != null ?
            new ObjectParameter("subreddit", subreddit) :
            new ObjectParameter("subreddit", typeof(string));


        var publishedTimestampParameter = publishedTimestamp.HasValue ?
            new ObjectParameter("publishedTimestamp", publishedTimestamp) :
            new ObjectParameter("publishedTimestamp", typeof(System.DateTime));


        var publishedMonthPrecisionParameter = publishedMonthPrecision.HasValue ?
            new ObjectParameter("publishedMonthPrecision", publishedMonthPrecision) :
            new ObjectParameter("publishedMonthPrecision", typeof(System.DateTime));


        var publishedWeekPrecisionParameter = publishedWeekPrecision.HasValue ?
            new ObjectParameter("publishedWeekPrecision", publishedWeekPrecision) :
            new ObjectParameter("publishedWeekPrecision", typeof(System.DateTime));


        var publishedDayPrecisionParameter = publishedDayPrecision.HasValue ?
            new ObjectParameter("publishedDayPrecision", publishedDayPrecision) :
            new ObjectParameter("publishedDayPrecision", typeof(System.DateTime));


        var publishedHourPrecisionParameter = publishedHourPrecision.HasValue ?
            new ObjectParameter("publishedHourPrecision", publishedHourPrecision) :
            new ObjectParameter("publishedHourPrecision", typeof(System.DateTime));


        var publishedMinutePrecisionParameter = publishedMinutePrecision.HasValue ?
            new ObjectParameter("publishedMinutePrecision", publishedMinutePrecision) :
            new ObjectParameter("publishedMinutePrecision", typeof(System.DateTime));


        var ingestedTimestampParameter = ingestedTimestamp.HasValue ?
            new ObjectParameter("ingestedTimestamp", ingestedTimestamp) :
            new ObjectParameter("ingestedTimestamp", typeof(System.DateTime));


        var urlParameter = url != null ?
            new ObjectParameter("url", url) :
            new ObjectParameter("url", typeof(string));


        var parentIdParameter = parentId != null ?
            new ObjectParameter("parentId", parentId) :
            new ObjectParameter("parentId", typeof(string));


        var postIdParameter = postId != null ?
            new ObjectParameter("postId", postId) :
            new ObjectParameter("postId", typeof(string));


        var parentUrlParameter = parentUrl != null ?
            new ObjectParameter("parentUrl", parentUrl) :
            new ObjectParameter("parentUrl", typeof(string));


        var postUrlParameter = postUrl != null ?
            new ObjectParameter("postUrl", postUrl) :
            new ObjectParameter("postUrl", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertComment1", newDocIdParameter, contentParameter, scoreParameter, controversialityParameter, gildedParameter, authorParameter, subredditParameter, publishedTimestampParameter, publishedMonthPrecisionParameter, publishedWeekPrecisionParameter, publishedDayPrecisionParameter, publishedHourPrecisionParameter, publishedMinutePrecisionParameter, ingestedTimestampParameter, urlParameter, parentIdParameter, postIdParameter, parentUrlParameter, postUrlParameter);
    }


    public virtual int InsertPost(string newDocId, string content, Nullable<int> score, Nullable<double> controversiality, Nullable<int> gilded, string author, string subreddit, Nullable<System.DateTime> publishedTimestamp, Nullable<System.DateTime> publishedMonthPrecision, Nullable<System.DateTime> publishedWeekPrecision, Nullable<System.DateTime> publishedDayPrecision, Nullable<System.DateTime> publishedHourPrecision, Nullable<System.DateTime> publishedMinutePrecision, Nullable<System.DateTime> ingestedTimestamp, string url, string title, string mediaPreviewUrl)
    {

        var newDocIdParameter = newDocId != null ?
            new ObjectParameter("NewDocId", newDocId) :
            new ObjectParameter("NewDocId", typeof(string));


        var contentParameter = content != null ?
            new ObjectParameter("content", content) :
            new ObjectParameter("content", typeof(string));


        var scoreParameter = score.HasValue ?
            new ObjectParameter("score", score) :
            new ObjectParameter("score", typeof(int));


        var controversialityParameter = controversiality.HasValue ?
            new ObjectParameter("controversiality", controversiality) :
            new ObjectParameter("controversiality", typeof(double));


        var gildedParameter = gilded.HasValue ?
            new ObjectParameter("gilded", gilded) :
            new ObjectParameter("gilded", typeof(int));


        var authorParameter = author != null ?
            new ObjectParameter("author", author) :
            new ObjectParameter("author", typeof(string));


        var subredditParameter = subreddit != null ?
            new ObjectParameter("subreddit", subreddit) :
            new ObjectParameter("subreddit", typeof(string));


        var publishedTimestampParameter = publishedTimestamp.HasValue ?
            new ObjectParameter("publishedTimestamp", publishedTimestamp) :
            new ObjectParameter("publishedTimestamp", typeof(System.DateTime));


        var publishedMonthPrecisionParameter = publishedMonthPrecision.HasValue ?
            new ObjectParameter("publishedMonthPrecision", publishedMonthPrecision) :
            new ObjectParameter("publishedMonthPrecision", typeof(System.DateTime));


        var publishedWeekPrecisionParameter = publishedWeekPrecision.HasValue ?
            new ObjectParameter("publishedWeekPrecision", publishedWeekPrecision) :
            new ObjectParameter("publishedWeekPrecision", typeof(System.DateTime));


        var publishedDayPrecisionParameter = publishedDayPrecision.HasValue ?
            new ObjectParameter("publishedDayPrecision", publishedDayPrecision) :
            new ObjectParameter("publishedDayPrecision", typeof(System.DateTime));


        var publishedHourPrecisionParameter = publishedHourPrecision.HasValue ?
            new ObjectParameter("publishedHourPrecision", publishedHourPrecision) :
            new ObjectParameter("publishedHourPrecision", typeof(System.DateTime));


        var publishedMinutePrecisionParameter = publishedMinutePrecision.HasValue ?
            new ObjectParameter("publishedMinutePrecision", publishedMinutePrecision) :
            new ObjectParameter("publishedMinutePrecision", typeof(System.DateTime));


        var ingestedTimestampParameter = ingestedTimestamp.HasValue ?
            new ObjectParameter("ingestedTimestamp", ingestedTimestamp) :
            new ObjectParameter("ingestedTimestamp", typeof(System.DateTime));


        var urlParameter = url != null ?
            new ObjectParameter("url", url) :
            new ObjectParameter("url", typeof(string));


        var titleParameter = title != null ?
            new ObjectParameter("title", title) :
            new ObjectParameter("title", typeof(string));


        var mediaPreviewUrlParameter = mediaPreviewUrl != null ?
            new ObjectParameter("mediaPreviewUrl", mediaPreviewUrl) :
            new ObjectParameter("mediaPreviewUrl", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPost", newDocIdParameter, contentParameter, scoreParameter, controversialityParameter, gildedParameter, authorParameter, subredditParameter, publishedTimestampParameter, publishedMonthPrecisionParameter, publishedWeekPrecisionParameter, publishedDayPrecisionParameter, publishedHourPrecisionParameter, publishedMinutePrecisionParameter, ingestedTimestampParameter, urlParameter, titleParameter, mediaPreviewUrlParameter);
    }

}

}
