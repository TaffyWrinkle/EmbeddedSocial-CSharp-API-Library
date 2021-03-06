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
    /// Extension methods for MyPushRegistrations.
    /// </summary>
    public static partial class MyPushRegistrationsExtensions
    {
            /// <summary>
            /// Register for push notifications or update an existing registration
            /// </summary>
            /// A push notification will be generated and sent for each activity in my
            /// notifications feed where the unread status is true.
            /// If multiple devices register for push notifications, then all
            /// those devices
            /// will get push notifications.
            /// Each push notification will have three components: (1) a human
            /// readable string
            /// that the mobile OS should display to the user, (2) a
            /// "publisher" string with
            /// value "EmbeddedSocial" to identify that the push notification
            /// came from
            /// this service, and (3) an "activityHandle" that identifies
            /// which activity
            /// in the notification feed this push notification is for.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='platform'>
            /// Platform type. Possible values include: 'Windows', 'Android', 'IOS'
            /// </param>
            /// <param name='registrationId'>
            /// Unique registration ID provided by the mobile OS.
            /// You must URL encode the registration ID.
            /// For Android, this is the GCM or FCM registration ID.
            /// For Windows, this is the PushNotificationChannel URI.
            /// For iOS, this is the device token.
            /// </param>
            /// <param name='request'>
            /// Put push registration request
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
            public static object PutPushRegistration(this IMyPushRegistrations operations, Platform platform, string registrationId, PutPushRegistrationRequest request, string authorization)
            {
                return Task.Factory.StartNew(s => ((IMyPushRegistrations)s).PutPushRegistrationAsync(platform, registrationId, request, authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Register for push notifications or update an existing registration
            /// </summary>
            /// A push notification will be generated and sent for each activity in my
            /// notifications feed where the unread status is true.
            /// If multiple devices register for push notifications, then all
            /// those devices
            /// will get push notifications.
            /// Each push notification will have three components: (1) a human
            /// readable string
            /// that the mobile OS should display to the user, (2) a
            /// "publisher" string with
            /// value "EmbeddedSocial" to identify that the push notification
            /// came from
            /// this service, and (3) an "activityHandle" that identifies
            /// which activity
            /// in the notification feed this push notification is for.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='platform'>
            /// Platform type. Possible values include: 'Windows', 'Android', 'IOS'
            /// </param>
            /// <param name='registrationId'>
            /// Unique registration ID provided by the mobile OS.
            /// You must URL encode the registration ID.
            /// For Android, this is the GCM or FCM registration ID.
            /// For Windows, this is the PushNotificationChannel URI.
            /// For iOS, this is the device token.
            /// </param>
            /// <param name='request'>
            /// Put push registration request
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
            public static async Task<object> PutPushRegistrationAsync(this IMyPushRegistrations operations, Platform platform, string registrationId, PutPushRegistrationRequest request, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutPushRegistrationWithHttpMessagesAsync(platform, registrationId, request, authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Unregister from push notifications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='platform'>
            /// Platform type. Possible values include: 'Windows', 'Android', 'IOS'
            /// </param>
            /// <param name='registrationId'>
            /// Unique registration ID provided by the mobile OS.
            /// You must URL encode the registration ID.
            /// For Android, this is the GCM registration ID.
            /// For Windows, this is the PushNotificationChannel URI.
            /// For iOS, this is the device token.
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
            public static object DeletePushRegistration(this IMyPushRegistrations operations, Platform platform, string registrationId, string authorization)
            {
                return Task.Factory.StartNew(s => ((IMyPushRegistrations)s).DeletePushRegistrationAsync(platform, registrationId, authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregister from push notifications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='platform'>
            /// Platform type. Possible values include: 'Windows', 'Android', 'IOS'
            /// </param>
            /// <param name='registrationId'>
            /// Unique registration ID provided by the mobile OS.
            /// You must URL encode the registration ID.
            /// For Android, this is the GCM registration ID.
            /// For Windows, this is the PushNotificationChannel URI.
            /// For iOS, this is the device token.
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
            public static async Task<object> DeletePushRegistrationAsync(this IMyPushRegistrations operations, Platform platform, string registrationId, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeletePushRegistrationWithHttpMessagesAsync(platform, registrationId, authorization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
