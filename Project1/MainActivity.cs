using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Project1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        int score;
        private EditText textInput;
        private Button checkButton, resetButton, hintButton;
        private TextView result, hint;
        private TextView shuffedLetters;
        private TextView coinView, mainCoin; //added coinView <Phong - 16/4/2019>
        private ImageView highscore;
        LetterStorage availableWords = new LetterStorage();

        private string guessWord;
        private string givenWord;
        private string shuffedWord;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            textInput = FindViewById<EditText>(Resource.Id.editText);
            checkButton = FindViewById<Button>(Resource.Id.check);
            resetButton = FindViewById<Button>(Resource.Id.reset);
            hintButton = FindViewById<Button>(Resource.Id.hint);
            result = FindViewById<TextView>(Resource.Id.result);
            hint = FindViewById<TextView>(Resource.Id.hint);
            shuffedLetters = FindViewById<TextView>(Resource.Id.shuffledLetters);

            givenWord = availableWords.randomWordLevel1();
            shuffedWord = availableWords.shuffleWord(givenWord);
            shuffedLetters.Text = shuffedWord;


            checkButton.Click += delegate {

                guessWord = textInput.Text;
                if(availableWords.compareWords(givenWord,guessWord))
                {
                    score += 10;
                    result.Text = "Score " + score;
                    textInput.Text = "";
                    renewWord();
                }
	};

            
        }
        //Function to renew the word that player has to guess
        /*
        renewWord()
        get a new random word and shuffle all the letters to display
        parameters: no parameters needed
        return: void
         */
        public void renewWord()
        {
            givenWord = availableWords.randomWordLevel1();
            shuffedWord = availableWords.shuffleWord(givenWord);
            shuffedLetters.Text = shuffedWord;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}