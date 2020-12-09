public class Shoping_Theme{
       void title_1(){
        label.Text("پیکس ها");
    }
    void title_2(){
        label.Text("اسکین ها");
    }
    void title_3(){
        label.Text("قدرت ها");
    }
    void Iteam_1(){
        //Iteam 1
    image.Show("01.png");
    label.Text("گاست وحشتناک ...");
        Level news = new Shop();
        news.Show();
        object p = Hide();
        //Iteam 2
        image.Show("02.png");
        label.Text("بزن بریم با ماشین هزار کیلیو متر!");
        object p1 = news.Show();
        //Iteam 3
        image.Show("03.png");
        label.Text("سرعت بیگر بینیم!");
        object p2 = news.Show();
        //Iteam 4
        image.Show("04.png");
        label.Text("ضد گشنگی");
        object p3 = news.Show();
    }
    void Iteam_2(){
                   //Iteam 1
        model.Show("01");
        label.Text("اسکین اشکان");
        Level news = new Shop_Skin();
        news.Show();
        object p = Hide();
        //Iteam 2
        model.Show("02");
        label.Text("اسکین قلو 1");
        object p1 = news.Show();
        //Iteam 3
        model.Show("03");
        label.Text("اسکین قلو 2");
        object p2 = news.Show();
        //Iteam 4
        Model.Show("04");
        label.Text("اسکین ربات متحرکت");
        object p3 = MessageBox.Show("ببخشید ولی، این آیتم در تیزن 2 میاد!");
    }
        void Iteams(){
        title_1.Show();
        Iteam_1.Show();
        title_2.Show();
        Iteam_2.Show();
        title_3.Show();
        Iteam_3.Show();

    }
}