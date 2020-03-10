﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;

namespace Azure.Storage
{
    /// <summary>
    /// Extension methods to make tests easier to author.
    /// </summary>
    public static partial class BlobTestExtensions
    {
        private static Uri ToHttps(Uri uri)
        {
            RequestUriBuilder builder = new RequestUriBuilder();
            builder.Reset(uri);
            builder.Scheme = Constants.Https;
            builder.Port = Constants.Blob.HttpsPort;
            return builder.ToUri();
        }

        public static AppendBlobClient WithCustomerProvidedKey(
            this AppendBlobClient blob,
            CustomerProvidedKey customerProvidedKey)
        {
            // this technically corrupts the field. But this is test-only code, we so we can get away with it.
            blob.SourceOptions.CustomerProvidedKey = customerProvidedKey;
            return new AppendBlobClient(
                ToHttps(blob.Uri),
                blob.Pipeline,
                blob.AuthenticationPolicy,
                blob.SourceOptions);
        }

        //TODO remove ToHttps() after service fixes HTTPS bug.
        public static AppendBlobClient WithEncryptionScope(
            this AppendBlobClient blob,
            string encryptionScope)
        {
            // this technically corrupts the field. But this is test-only code, we so we can get away with it.
            blob.SourceOptions.EncryptionScope = encryptionScope;
            return new AppendBlobClient(
                ToHttps(blob.Uri),
                blob.Pipeline,
                blob.AuthenticationPolicy,
                blob.SourceOptions);
        }

        public static BlockBlobClient WithCustomerProvidedKey(
            this BlockBlobClient blob,
            CustomerProvidedKey customerProvidedKey)
        {
            // this technically corrupts the field. But this is test-only code, we so we can get away with it.
            blob.SourceOptions.CustomerProvidedKey = customerProvidedKey;
            return new BlockBlobClient(
                ToHttps(blob.Uri),
                blob.Pipeline,
                blob.AuthenticationPolicy,
                blob.SourceOptions);
        }

        //TODO remove ToHttps() after service fixes HTTPS bug.
        public static BlockBlobClient WithEncryptionScope(
            this BlockBlobClient blob,
            string encryptionScope)
        {
            // this technically corrupts the field. But this is test-only code, we so we can get away with it.
            blob.SourceOptions.EncryptionScope = encryptionScope;
            return new BlockBlobClient(
                ToHttps(blob.Uri),
                blob.Pipeline,
                blob.AuthenticationPolicy,
                blob.SourceOptions);
        }

        public static PageBlobClient WithCustomerProvidedKey(
            this PageBlobClient blob,
            CustomerProvidedKey customerProvidedKey)
        {
            // this technically corrupts the field. But this is test-only code, we so we can get away with it.
            blob.SourceOptions.CustomerProvidedKey = customerProvidedKey;
            return new PageBlobClient(
                ToHttps(blob.Uri),
                blob.Pipeline,
                blob.AuthenticationPolicy,
                blob.SourceOptions);
        }

        //TODO remove ToHttps() after service fixes HTTPS bug.
        public static PageBlobClient WithEncryptionScope(
            this PageBlobClient blob,
            string encryptionScope)
        {
            // this technically corrupts the field. But this is test-only code, we so we can get away with it.
            blob.SourceOptions.EncryptionScope = encryptionScope;
            return new PageBlobClient(
                ToHttps(blob.Uri),
                blob.Pipeline,
                blob.AuthenticationPolicy,
                blob.SourceOptions);
        }

        /// <summary>
        /// Convert a base RequestConditions to BlobRequestConditions.
        /// </summary>
        /// <param name="conditions">The <see cref="RequestConditions"/>.</param>
        /// <returns>The <see cref="BlobRequestConditions"/>.</returns>
        public static BlobRequestConditions ToBlobRequestConditions(this RequestConditions conditions) =>
            conditions == null ?
                null :
                new BlobRequestConditions
                {
                    IfMatch = conditions.IfMatch,
                    IfNoneMatch = conditions.IfNoneMatch,
                    IfModifiedSince = conditions.IfModifiedSince,
                    IfUnmodifiedSince = conditions.IfUnmodifiedSince
                };
    }
}
