using System;

using System.ServiceModel;

using System.Windows;


namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isFirstMessage = true;

        Uri uriAddress = new Uri("http://localhost:4000/SayService");

        BasicHttpBinding bind = new BasicHttpBinding();

        ChannelFactory<IMessageContract> channelFactory = null;

        IMessageContract ImessageChannel = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (channelFactory == null)
            {
                channelFactory = new ChannelFactory<IMessageContract>(bind, new EndpointAddress(uriAddress));
                ImessageChannel = channelFactory.CreateChannel();
            }

            if (channelFactory != null && ImessageChannel != null)
            {
                MessageBox.Text += Environment.NewLine + DateTime.Now + " I said: " + TypingBox.Text + Environment.NewLine;
                MessageBox.Text += ImessageChannel.Say(TypingBox.Text) + Environment.NewLine;
                GotMessage();
            }
        }

        private void GotMessage()
        {
            TypingBox.Clear();
            MessageBox.ScrollToEnd();

        }
    }
}
