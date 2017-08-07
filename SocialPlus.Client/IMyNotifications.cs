// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// MyNotifications operations.
    /// </summary>
    public partial interface IMyNotifications
    {
        /// <summary>
        /// Update notifications status
        /// </summary>
        /// This API call records the most recent notification that the user
        /// has read (or seen).
        /// In the GET notifications API call, each notification
        /// will have an unread status.
        /// Any notifications that are newer than this
        /// ReadActivityHandle will have an unread status of true.
        /// Any notifications that correspond to this
        /// ReadActivityHandle or older will have an unread status of false.
        /// If this API call has never been made, then all
        /// notifications will have an unread status of true.
        /// <param name='request'>
        /// Put notifications status request
        /// </param>
        /// <param name='authorization'>
        /// Format is: "Scheme CredentialsList". Possible values are:
        /// 
        /// - Anon AK=AppKey
        /// 
        /// - SocialPlus TK=SessionToken
        /// 
        /// - Facebook AK=AppKey|TK=AccessToken
        /// 
        /// - Google AK=AppKey|TK=AccessToken
        /// 
        /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
        /// 
        /// - Microsoft AK=AppKey|TK=AccessToken
        /// 
        /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PutNotificationsStatusWithHttpMessagesAsync(PutNotificationsStatusRequest request, string authorization, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get my notifications
        /// </summary>
        /// This gets a feed of activities.
        /// This feed is time ordered, with the most recent
        /// activity first.
        /// An activity is added to this feed when any user other
        /// than myself does one of the following 6 actions:
        /// (a) creates a comment to my topic; (b) creates a reply
        /// to my comment; (c) likes my topic; (d) follows me;
        /// (e) requests to follow me when I'm a private user; (f)
        /// accepts my request to follow them when they are a private user.
        /// Each activity has an unread status, which is
        /// controlled by doing a PUT on the status API call.
        /// If a user that performed the activity is deleted, then
        /// that activity will no longer appear in this feed.
        /// If an activity is performed on content that is then
        /// deleted, that activity will no longer appear in this feed.
        /// If a user has un-done an activity (e.g. unlike a
        /// previous like), then that activity will no longer appear in this
        /// feed.
        /// When activityType is Like, the activityHandle is the
        /// likeHandle that uniquely identifies the new like.
        /// When activityType is Comment, the activityHandle is
        /// the commentHandle that uniquely identifies the new comment.
        /// When activityType is Reply, the activityHandle is the
        /// replyHandle that uniquely identifies the new reply.
        /// ActivityType values of CommentPeer and ReplyPeer are
        /// currently not used.
        /// When activityType is Following or FollowRequest or
        /// FollowAccept, the activityHandle is the relationshipHandle
        /// that uniquely identifies the relationship between the
        /// two users.
        /// <param name='authorization'>
        /// Format is: "Scheme CredentialsList". Possible values are:
        /// 
        /// - Anon AK=AppKey
        /// 
        /// - SocialPlus TK=SessionToken
        /// 
        /// - Facebook AK=AppKey|TK=AccessToken
        /// 
        /// - Google AK=AppKey|TK=AccessToken
        /// 
        /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
        /// 
        /// - Microsoft AK=AppKey|TK=AccessToken
        /// 
        /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
        /// </param>
        /// <param name='cursor'>
        /// Current read cursor
        /// </param>
        /// <param name='limit'>
        /// Number of items to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<FeedResponseActivityView>> GetNotificationsWithHttpMessagesAsync(string authorization, string cursor = default(string), int? limit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get unread notifications count
        /// </summary>
        /// This returns a count of activities in my notification feed that
        /// have an unread status of true.
        /// <param name='authorization'>
        /// Format is: "Scheme CredentialsList". Possible values are:
        /// 
        /// - Anon AK=AppKey
        /// 
        /// - SocialPlus TK=SessionToken
        /// 
        /// - Facebook AK=AppKey|TK=AccessToken
        /// 
        /// - Google AK=AppKey|TK=AccessToken
        /// 
        /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
        /// 
        /// - Microsoft AK=AppKey|TK=AccessToken
        /// 
        /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CountResponse>> GetNotificationsCountWithHttpMessagesAsync(string authorization, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}