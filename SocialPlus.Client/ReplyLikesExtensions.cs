// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for ReplyLikes.
    /// </summary>
    public static partial class ReplyLikesExtensions
    {
            /// <summary>
            /// Get likes for reply
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='replyHandle'>
            /// Reply handle
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
            /// <param name='cursor'>
            /// Current read cursor
            /// </param>
            /// <param name='limit'>
            /// Number of items to return
            /// </param>
            public static FeedResponseUserCompactView GetLikes(this IReplyLikes operations, string replyHandle, string authorization, string cursor = default(string), int? limit = default(int?))
            {
                return Task.Factory.StartNew(s => ((IReplyLikes)s).GetLikesAsync(replyHandle, authorization, cursor, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get likes for reply
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='replyHandle'>
            /// Reply handle
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
            /// <param name='cursor'>
            /// Current read cursor
            /// </param>
            /// <param name='limit'>
            /// Number of items to return
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeedResponseUserCompactView> GetLikesAsync(this IReplyLikes operations, string replyHandle, string authorization, string cursor = default(string), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLikesWithHttpMessagesAsync(replyHandle, authorization, cursor, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add like to reply
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='replyHandle'>
            /// Reply handle
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
            public static object PostLike(this IReplyLikes operations, string replyHandle, string authorization)
            {
                return Task.Factory.StartNew(s => ((IReplyLikes)s).PostLikeAsync(replyHandle, authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add like to reply
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='replyHandle'>
            /// Reply handle
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostLikeAsync(this IReplyLikes operations, string replyHandle, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostLikeWithHttpMessagesAsync(replyHandle, authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove like from reply
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='replyHandle'>
            /// Reply handle
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
            public static object DeleteLike(this IReplyLikes operations, string replyHandle, string authorization)
            {
                return Task.Factory.StartNew(s => ((IReplyLikes)s).DeleteLikeAsync(replyHandle, authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove like from reply
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='replyHandle'>
            /// Reply handle
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteLikeAsync(this IReplyLikes operations, string replyHandle, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteLikeWithHttpMessagesAsync(replyHandle, authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
