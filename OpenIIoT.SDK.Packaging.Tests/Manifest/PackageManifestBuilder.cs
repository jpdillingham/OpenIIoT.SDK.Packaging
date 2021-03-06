﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄███████▄                                                                 ▄▄▄▄███▄▄▄▄                                                                ▀█████████▄
      █     ███    ███                                                               ▄██▀▀▀███▀▀▀██▄                                                                ███    ███
      █     ███    ███   ▄█████   ▄██████    █  █▄     ▄█████     ▄████▄     ▄█████  ███   ███   ███   ▄█████  ██▄▄▄▄   █     ▄█████    ▄█████   ▄█████     ██      ███    ███ ██   █   █   █       ██████▄     ▄█████    █████
      █     ███    ███   ██   ██ ██    ██   ██ ▄██▀    ██   ██   ██    ▀    ██   █   ███   ███   ███   ██   ██ ██▀▀▀█▄ ██    ██   ▀█   ██   █    ██  ▀  ▀███████▄  ▄███▄▄▄██▀  ██   ██ ██  ██       ██   ▀██   ██   █    ██  ██
      █   ▀█████████▀    ██   ██ ██    ▀    ██▐█▀      ██   ██  ▄██        ▄██▄▄     ███   ███   ███   ██   ██ ██   ██ ██▌  ▄██▄▄     ▄██▄▄      ██         ██  ▀ ▀▀███▀▀▀██▄  ██   ██ ██▌ ██       ██    ██  ▄██▄▄     ▄██▄▄█▀
      █     ███        ▀████████ ██    ▄  ▀▀████     ▀████████ ▀▀██ ███▄  ▀▀██▀▀     ███   ███   ███ ▀████████ ██   ██ ██  ▀▀██▀▀    ▀▀██▀▀    ▀███████     ██      ███    ██▄ ██   ██ ██  ██       ██    ██ ▀▀██▀▀    ▀███████
      █     ███          ██   ██ ██    ██   ██ ▀██▄    ██   ██   ██    ██   ██   █   ███   ███   ███   ██   ██ ██   ██ ██    ██        ██   █     ▄  ██     ██      ███    ███ ██   ██ ██  ██▌    ▄ ██   ▄██   ██   █    ██  ██
      █    ▄████▀        ██   █▀ ██████▀    ▀█   ▀█▀   ██   █▀   ██████▀    ███████   ▀█   ███   █▀    ██   █▀  █   █  █     ██        ███████  ▄████▀     ▄██▀   ▄█████████▀  ██████  █   ████▄▄██ ██████▀    ███████   ██  ██
      █
      █       ███
      █   ▀█████████▄
      █      ▀███▀▀██    ▄█████   ▄█████     ██      ▄█████
      █       ███   ▀   ██   █    ██  ▀  ▀███████▄   ██  ▀
      █       ███      ▄██▄▄      ██         ██  ▀   ██
      █       ███     ▀▀██▀▀    ▀███████     ██    ▀███████
      █       ███       ██   █     ▄  ██     ██       ▄  ██
      █      ▄████▀     ███████  ▄████▀     ▄██▀    ▄████▀
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Unit tests for the PackageManifestBuilder class.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System.Collections.Generic;
using Xunit;

namespace OpenIIoT.SDK.Packaging.Tests.Manifest
{
    /// <summary>
    ///     Unit tests for the <see cref="Packaging.Manifest.PackageManifest"/> class.
    /// </summary>
    public class PackageManifestBuilder
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="PackageManifestBuilder"/> class.
        /// </summary>
        public PackageManifestBuilder()
        {
            Builder = new Packaging.Manifest.PackageManifestBuilder();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        ///     Gets or sets the Builder under test.
        /// </summary>
        public Packaging.Manifest.PackageManifestBuilder Builder { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.AddFile(Packaging.Manifest.PackageManifestFile)"/> method.
        /// </summary>
        [Fact]
        public void AddFile()
        {
            Packaging.Manifest.PackageManifestFile file = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source",
                Checksum = "checksum",
            };

            Builder.AddFile(file);

            Assert.Equal(1, Builder.Manifest.Files.Count);
            Assert.Equal("source", Builder.Manifest.Files[0].Source);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.AddFile(Packaging.Manifest.PackageManifestFile)"/>
        ///     method with a file matching the type of a previously added file.
        /// </summary>
        [Fact]
        public void AddFileExistingType()
        {
            Packaging.Manifest.PackageManifestFile file = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source",
                Checksum = "checksum",
            };

            Packaging.Manifest.PackageManifestFile file2 = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source2",
                Checksum = "checksum",
            };

            Builder.AddFile(file);
            Builder.AddFile(file2);

            Assert.Equal(2, Builder.Manifest.Files.Count);
            Assert.Equal("source", Builder.Manifest.Files[0].Source);
            Assert.Equal("source2", Builder.Manifest.Files[1].Source);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.BuildDefault"/> method.
        /// </summary>
        [Fact]
        public void BuildDefault()
        {
            Packaging.Manifest.PackageManifest manifest = Builder.BuildDefault().Manifest;

            Assert.NotEqual(string.Empty, manifest.Title);
            Assert.NotEqual(string.Empty, manifest.Version);
            Assert.NotEqual(string.Empty, manifest.Namespace);
            Assert.NotEqual(string.Empty, manifest.Description);
            Assert.NotEqual(string.Empty, manifest.Publisher);
            Assert.NotEqual(string.Empty, manifest.Copyright);
            Assert.NotEqual(string.Empty, manifest.License);
            Assert.NotEqual(string.Empty, manifest.Url);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.ClearFiles"/> method.
        /// </summary>
        [Fact]
        public void ClearFiles()
        {
            Packaging.Manifest.PackageManifestFile file = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source",
                Checksum = "checksum",
            };

            Builder.AddFile(file);

            Assert.Equal(1, Builder.Manifest.Files.Count);

            Builder.ClearFiles();

            Assert.Equal(0, Builder.Manifest.Files.Count);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.ClearFiles"/> method when the file list is empty.
        /// </summary>
        [Fact]
        public void ClearFilesNoFiles()
        {
            Builder.ClearFiles();

            Assert.Null(Builder.Manifest.Files);
        }

        /// <summary>
        ///     Tests the Constructor and all properties.
        /// </summary>
        [Fact]
        public void Constructor()
        {
            Packaging.Manifest.PackageManifestBuilder test = new Packaging.Manifest.PackageManifestBuilder();

            Assert.NotNull(test.Manifest);
            Assert.Null(test.Manifest.Title);

            Packaging.Manifest.PackageManifest manifest = new Packaging.Manifest.PackageManifest();
            manifest.Title = "manifest";

            test = new Packaging.Manifest.PackageManifestBuilder(manifest);

            Assert.NotNull(test.Manifest);
            Assert.Equal(test.Manifest.Title, "manifest");
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Copyright(string)"/> method.
        /// </summary>
        [Fact]
        public void Copyright()
        {
            Assert.Null(Builder.Manifest.Copyright);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Copyright("Copyright");

            Assert.Same(builder, Builder);
            Assert.Equal("Copyright", Builder.Manifest.Copyright);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Description(string)"/> method.
        /// </summary>
        [Fact]
        public void Description()
        {
            Assert.Null(Builder.Manifest.Description);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Description("Description");

            Assert.Same(builder, Builder);
            Assert.Equal("Description", Builder.Manifest.Description);
        }

        /// <summary>
        ///     Tests the
        ///     <see cref="Packaging.Manifest.PackageManifestBuilder.Files(IList{Packaging.Manifest.PackageManifestFile})"/> method.
        /// </summary>
        [Fact]
        public void Files()
        {
            Assert.Null(Builder.Manifest.Files);

            IList<Packaging.Manifest.PackageManifestFile> files = new List<Packaging.Manifest.PackageManifestFile>();
            Packaging.Manifest.PackageManifestBuilder builder = Builder.Files(files);

            Assert.Same(builder, Builder);
            Assert.Same(files, Builder.Manifest.Files);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.License(string)"/> method.
        /// </summary>
        [Fact]
        public void License()
        {
            Assert.Null(Builder.Manifest.License);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.License("License");

            Assert.Same(builder, Builder);
            Assert.Equal("License", Builder.Manifest.License);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Namespace(string)"/> method.
        /// </summary>
        [Fact]
        public void Namespace()
        {
            Assert.Null(Builder.Manifest.Namespace);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Namespace("Namespace");

            Assert.Same(builder, Builder);
            Assert.Equal("Namespace", Builder.Manifest.Namespace);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Publisher(string)"/> method.
        /// </summary>
        [Fact]
        public void Publisher()
        {
            Assert.Null(Builder.Manifest.Publisher);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Publisher("Publisher");

            Assert.Same(builder, Builder);
            Assert.Equal("Publisher", Builder.Manifest.Publisher);
        }

        /// <summary>
        ///     Tests the
        ///     <see cref="Packaging.Manifest.PackageManifestBuilder.RemoveFile(Packaging.Manifest.PackageManifestFile)"/> method.
        /// </summary>
        [Fact]
        public void RemoveFile()
        {
            Packaging.Manifest.PackageManifestFile file = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source",
                Checksum = "checksum",
            };

            Builder.AddFile(file);

            Assert.Equal(1, Builder.Manifest.Files.Count);
            Assert.Equal("source", Builder.Manifest.Files[0].Source);

            Builder.RemoveFile(file);

            Assert.Equal(0, Builder.Manifest.Files.Count);
        }

        /// <summary>
        ///     Tests the
        ///     <see cref="Packaging.Manifest.PackageManifestBuilder.RemoveFile(Packaging.Manifest.PackageManifestFile)"/> method.
        /// </summary>
        [Fact]
        public void RemoveFileNotAdded()
        {
            Packaging.Manifest.PackageManifestFile file = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source",
                Checksum = "checksum",
            };

            Packaging.Manifest.PackageManifestFile file2 = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source2",
                Checksum = "checksum2",
            };

            Builder.AddFile(file);

            Assert.Equal(1, Builder.Manifest.Files.Count);
            Assert.Equal("source", Builder.Manifest.Files[0].Source);

            Builder.RemoveFile(file2);

            Assert.Equal(1, Builder.Manifest.Files.Count);
        }

        /// <summary>
        ///     Tests the
        ///     <see cref="Packaging.Manifest.PackageManifestBuilder.RemoveFile(Packaging.Manifest.PackageManifestFile)"/> method
        ///     when no files have yet been added to the list.
        /// </summary>
        [Fact]
        public void RemoveFileNoFiles()
        {
            Packaging.Manifest.PackageManifestFile file = new Packaging.Manifest.PackageManifestFile()
            {
                Source = "source",
                Checksum = "checksum",
            };

            Builder.RemoveFile(file);

            Assert.Null(Builder.Manifest.Files);
        }

        /// <summary>
        ///     Tests the
        ///     <see cref="Packaging.Manifest.PackageManifestBuilder.Signature(Packaging.Manifest.PackageManifestSignature)"/> method.
        /// </summary>
        [Fact]
        public void Signature()
        {
            Assert.Null(Builder.Manifest.Signature);

            Packaging.Manifest.PackageManifestSignature signature = new Packaging.Manifest.PackageManifestSignature();
            Packaging.Manifest.PackageManifestBuilder builder = Builder.Signature(signature);

            Assert.Same(builder, Builder);
            Assert.Same(signature, Builder.Manifest.Signature);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Title(string)"/> method.
        /// </summary>
        [Fact]
        public void Title()
        {
            Assert.Null(Builder.Manifest.Title);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Title("Title");

            Assert.Same(builder, Builder);
            Assert.Equal("Title", Builder.Manifest.Title);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Url(string)"/> method.
        /// </summary>
        [Fact]
        public void Url()
        {
            Assert.Null(Builder.Manifest.Url);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Url("Url");

            Assert.Same(builder, Builder);
            Assert.Equal("Url", Builder.Manifest.Url);
        }

        /// <summary>
        ///     Tests the <see cref="Packaging.Manifest.PackageManifestBuilder.Version(string)"/> method.
        /// </summary>
        [Fact]
        public void Version()
        {
            Assert.Null(Builder.Manifest.Version);

            Packaging.Manifest.PackageManifestBuilder builder = Builder.Version("Version");

            Assert.Same(builder, Builder);
            Assert.Equal("Version", Builder.Manifest.Version);
        }

        #endregion Public Methods
    }
}