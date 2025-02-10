namespace CalculateArea;

public partial class AreaCalcPage : ContentPage
{
    private string gender = "Male"; 
    private double weight = 90;     
    private double height = 50;     

    public AreaCalcPage()
    {
        InitializeComponent();
        FrameMale.BorderColor = Colors.Blue; 
    }

    
    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        gender = "Male";
        FrameMale.BorderColor = Colors.Blue;
        FrameFemale.BorderColor = Colors.Transparent;
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        gender = "Female";
        FrameFemale.BorderColor = Colors.Pink;
        FrameMale.BorderColor = Colors.Transparent;
    }

    
    private void SliderWeight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        weight = e.NewValue;
    }

    
    private void SliderHeight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        height = e.NewValue;
    }

    
    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
    {
        if (height == 0)
        {
            DisplayAlert("Error", "Height cannot be zero.", "OK");
            return;
        }

        
        double bmi = (weight * 703) / (height * height);
        bmi = Math.Round(bmi, 1);

        
        string status = "";
        string recommendations = "";

        if (gender == "Male")
        {
            if (bmi < 18.5)
            {
                status = "Underweight";
                recommendations = "Increase calorie intake with nutrient-rich foods. Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
            }
            else if (bmi < 25)
            {
                status = "Normal weight";
                recommendations = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
            }
            else if (bmi < 30)
            {
                status = "Overweight";
                recommendations = "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises and strength training. Drink plenty of water and track your progress.";
            }
            else
            {
                status = "Obese";
                recommendations = "Consult a doctor for personalized guidance. Start with low-impact exercises. Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
            }
        }
        else 
        {
            if (bmi < 18)
            {
                status = "Underweight";
                recommendations = "Increase calorie intake with nutrient-rich foods. Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
            }
            else if (bmi < 24)
            {
                status = "Normal weight";
                recommendations = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
            }
            else if (bmi < 29)
            {
                status = "Overweight";
                recommendations = "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises and strength training. Drink plenty of water and track your progress.";
            }
            else
            {
                status = "Obese";
                recommendations = "Consult a doctor for personalized guidance. Start with low-impact exercises. Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
            }
        }

        
        string message = $"Your BMI is {bmi}.\nStatus: {status}\n\nRecommendations:\n{recommendations}";

        DisplayAlert("BMI Result", message, "OK");
    }
}
