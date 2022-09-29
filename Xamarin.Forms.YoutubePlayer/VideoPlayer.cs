namespace Xamarin.Forms.YoutubePlayer
{
    public class VideoPlayer : View
    {
        public static string ApiKey { get; set; }

        public static readonly BindableProperty VideoIdProperty =
            BindableProperty.Create(
                nameof(VideoId),
                typeof(string),
                typeof(VideoPlayer),
                null);

        public static readonly BindableProperty AutoPlayProperty =
            BindableProperty.Create(
                nameof(AutoPlay),
                typeof(bool),
                typeof(VideoPlayer),
                false);

        public string VideoId
        {
            get => (string)GetValue(VideoIdProperty);
            set => SetValue(VideoIdProperty, value);
        }

        public bool AutoPlay
        {
            get => (bool)GetValue(AutoPlayProperty);
            set => SetValue(AutoPlayProperty, value);
        }
    }
}
