using ShowCaseTizen.Services.FormsVideoLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShowCaseTizen.Services
{
    public class VideoPlayer : View
    {
        // Source property
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Source), typeof(VideoSource), typeof(VideoPlayer), null);

        [TypeConverter(typeof(VideoSourceConverter))]
        public VideoSource Source
        {
            set { SetValue(SourceProperty, value); }
            get { return (VideoSource)GetValue(SourceProperty); }
        }

        // AutoPlay property
        public static readonly BindableProperty AutoPlayProperty =
            BindableProperty.Create(nameof(AutoPlay), typeof(bool), typeof(VideoPlayer), true);

        public bool AutoPlay
        {
            set { SetValue(AutoPlayProperty, value); }
            get { return (bool)GetValue(AutoPlayProperty); }
        }
    }
    namespace FormsVideoLibrary
    {
        [TypeConverter(typeof(VideoSourceConverter))]
        public abstract class VideoSource : Element
        {
            public static VideoSource FromUri(string uri)
            {
                return new UriVideoSource() { Uri = uri };
            }

            public static VideoSource FromFile(string file)
            {
                return new FileVideoSource() { File = file };
            }

            public static VideoSource FromResource(string path)
            {
                return new ResourceVideoSource() { Path = path };
            }
        }
    }

    namespace FormsVideoLibrary
    {
        public class UriVideoSource : VideoSource
        {
            public static readonly BindableProperty UriProperty =
                BindableProperty.Create(nameof(Uri), typeof(string), typeof(UriVideoSource));

            public string Uri
            {
                set { SetValue(UriProperty, value); }
                get { return (string)GetValue(UriProperty); }
            }
        }
    }

    namespace FormsVideoLibrary
    {
        public class ResourceVideoSource : VideoSource
        {
            public static readonly BindableProperty PathProperty =
                BindableProperty.Create(nameof(Path), typeof(string), typeof(ResourceVideoSource));

            public string Path
            {
                set { SetValue(PathProperty, value); }
                get { return (string)GetValue(PathProperty); }
            }
        }
    }

    namespace FormsVideoLibrary
    {
        public class FileVideoSource : VideoSource
        {
            public static readonly BindableProperty FileProperty =
                      BindableProperty.Create(nameof(File), typeof(string), typeof(FileVideoSource));

            public string File
            {
                set { SetValue(FileProperty, value); }
                get { return (string)GetValue(FileProperty); }
            }
        }
    }

    namespace FormsVideoLibrary
    {
        public class VideoSourceConverter : TypeConverter
        {
            public override object ConvertFromInvariantString(string value)
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    Uri uri;
                    return Uri.TryCreate(value, UriKind.Absolute, out uri) && uri.Scheme != "file" ?
                                    VideoSource.FromUri(value) : VideoSource.FromResource(value);
                }

                throw new InvalidOperationException("Cannot convert null or whitespace to ImageSource");
            }
        }
    }
}
