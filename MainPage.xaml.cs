 public partial class MainPage : ContentPage
 {
     public MainPage()
     {
         InitializeComponent();
     }
     private void Button1_Click(object sender, EventArgs e)
     {
         label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);
     }

     private void Button2_Click(object sender, EventArgs e)
     {
         label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - 1);
     }
 }
