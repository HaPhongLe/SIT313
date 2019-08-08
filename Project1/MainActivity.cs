using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Project1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //declare variables needed
        int score;
        public int coin = 500;
        private EditText textInput;
        private Button checkButton, resetButton, hintButton, nextLevelButton;
        private TextView result, hint;
        private TextView shuffedLetters;
        private TextView coinField;
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


            //get the elements from the layout
            textInput = FindViewById<EditText>(Resource.Id.editText);
            checkButton = FindViewById<Button>(Resource.Id.check);
            resetButton = FindViewById<Button>(Resource.Id.reset);
            nextLevelButton = FindViewById<Button>(Resource.Id.nextLevel);
            hintButton = FindViewById<Button>(Resource.Id.hint);
            result = FindViewById<TextView>(Resource.Id.result);
            hint = FindViewById<TextView>(Resource.Id.hintField);
            shuffedLetters = FindViewById<TextView>(Resource.Id.shuffledLetters);
            coinField = FindViewById<TextView>(Resource.Id.coin);
   
            renewWord();
            hint.Text = "";

            coin = retrieveCoin();
            coinField.Text = "Coin: " + coin;// display coin

            /*
            checkButton is clicked
            check the word that user guess with the given word
            if they match coin and score is increased
            if they don't match, display an appropriate message
            */
            checkButton.Click += delegate {

                guessWord = textInput.Text;
                if(availableWords.compareWords(givenWord,guessWord))
                {
                    score += 10;
                    coin += 20;
                    editCoin(coin);
                    result.Text = "Score: " + score;
                    coinField.Text = "Coin: " + coin;
                    textInput.Text = "";
                    hint.Text = "";
                    renewWord();
                }
                else
                {
                    result.Text = "Score: " + score;
                    Toast.MakeText(this, "Try another word!", ToastLength.Long).Show();
                    textInput.Text = "";
                }

                //this function reset the game, give new shuffled word 
                /*
                resetButton clicked 
                everytime it's clicked a new word is chosen and shuffled
                textInput is set to empty and score is set to 0
                hint is clear
                 */
            resetButton.Click += delegate {


                renewWord();
                score = 0;
                result.Text = "Score: 0";
                textInput.Text = "";
                hint.Text = "";
                
	};
            };
            //this click event brings user to the next Level if they've got a certain score
            //if they haven't got the certain score, a message is displayed

            nextLevelButton.Click += delegate {
                if(score >= 200)
                {
                    renewWord();
                    //score = 0;
                    //result.Text = "Score: 0";
                    textInput.Text = "";
                    hint.Text = "";
                    Intent intent = new Intent(this, typeof(Level2Activity));
                    
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "You can not go to level 2 unless you get 200 scores!", ToastLength.Long).Show();
                }
     

	};
            //this Click even happens when user click hint button
            //if user has enough coins and all the hints haven't been revealed, a new letter of the word is revealed
            //other case, an appropriate message will be displayed
            hintButton.Click += delegate {
                if(coin < 100 )
                {
                    Toast.MakeText(this, "You don't have enough money to buy hint!", ToastLength.Long).Show();
                    return;
                }
	
                if(givenWord.Length.CompareTo(hint.Text.Length) < 0 )
                {
                    Toast.MakeText(this, "All hints have been given!", ToastLength.Long).Show();
                    return;
                }

                availableWords.giveHint(givenWord, hint, coin);
                //coin gets minused
                coin = coin - 100;
                editCoin(coin);
                coinField.Text = "Coin: " + coin;
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

        /*
   editCoin()
   take the current amount of coin and put it into the ISharedPreferences
   parameters: current number of coin in Integer form
   return: void, the function just edit the coin in the SharedPreference, doesn't return anything
    */
        public void editCoin(int coin)
        {
            ISharedPreferences preferences = Application.Context.GetSharedPreferences("Coin", FileCreationMode.Private);
            ISharedPreferencesEditor editor = preferences.Edit();
            editor.PutInt("coin", coin);
            editor.Apply();
           
        }
        //retrieve the value of coin from ISharedPreference
        /*
        retrieveCoin()
        retrieve the amount of coin currently holding in the ISharedPreference
        parameters: no parameters needed
        returns: integer contains the number of coins.
         */
        public int retrieveCoin()
        {
            int coin1;
            ISharedPreferences preferences = Application.Context.GetSharedPreferences("Coin", FileCreationMode.Private);

            coin1 = preferences.GetInt("coin", 0);
            return coin1;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }

}
