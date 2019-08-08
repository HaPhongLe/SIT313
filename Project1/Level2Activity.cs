
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project1
{
    [Activity(Label = "Level2Activity")]
    public class Level2Activity : Activity
    {
        int score;
        int coinLevel2;
        private EditText textInput;
        private Button checkButton, resetButton, hintButton, previousLevelButton;
        private TextView result, hint;
        private TextView shuffedLetters;
        private TextView coinField;
        private ImageView highscore;
        LetterStorage availableWords = new LetterStorage();

        private string guessWord;
        private string givenWord;
        private string shuffedWord;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_level2);

            coinLevel2 = retrieveCoin();

            coinField = FindViewById<TextView>(Resource.Id.coin);
            coinField.Text = "Coin: " + coinLevel2;

            textInput = FindViewById<EditText>(Resource.Id.editText);
            checkButton = FindViewById<Button>(Resource.Id.check);
            resetButton = FindViewById<Button>(Resource.Id.reset);
            previousLevelButton = FindViewById<Button>(Resource.Id.previousLevel);
            hintButton = FindViewById<Button>(Resource.Id.hint);
            result = FindViewById<TextView>(Resource.Id.result);
            hint = FindViewById<TextView>(Resource.Id.hintField);
            shuffedLetters = FindViewById<TextView>(Resource.Id.shuffledLetters);



            renewWord();
            /*
            checkButton is clicked
            check the word that user guess with the given word
            if they match coin and score is increased
            if they don't match, display an appropriate message
            */
            checkButton.Click += delegate {

                guessWord = textInput.Text;
                if (availableWords.compareWords(givenWord, guessWord))
                {
                    score += 10;
                    coinLevel2 += 20;
                    editCoin(coinLevel2);
                    result.Text = "Score: " + score;
                    coinField.Text = "Coin: " + coinLevel2;
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
                resetButton
                set the click listener for resetButton, everytime it's clicked a new word is chosen and shuffled
                textInput is set to empty and score is set to 0
                hint is clear
                 */
                resetButton.Click += delegate {


                    renewWord();
                    score = 0;
                    result.Text = "Score: 0";
                    textInput.Text = "";

                };
            };


            //this Click even happens when user click hint button
            //if user has enough coins and all the hints haven't been revealed, a new letter of the word is revealed
            //other case, an appropriate message will be displayed
            hintButton.Click += delegate {
                if (coinLevel2 < 100)
                {
                    Toast.MakeText(this, "You don't have enough money to buy hint!", ToastLength.Long).Show();
                    return;
                }

                if (givenWord.Length.CompareTo(hint.Text.Length) < 0)
                {
                    Toast.MakeText(this, "All hints have been given!", ToastLength.Long).Show();
                    return;
                }

                availableWords.giveHint(givenWord, hint, coinLevel2);
                //coin gets minused
                coinLevel2 = coinLevel2 - 100;
                editCoin(coinLevel2);
                coinField.Text = "Coin: " + coinLevel2;
            };

            previousLevelButton.Click += delegate {

                Intent intent = new Intent(this, typeof(MainActivity));
                //score = 0;
                //result.Text = "Score: " + score;


                StartActivity(intent);
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
            givenWord = availableWords.randomWordLevel2();
            shuffedWord = availableWords.shuffleWord(givenWord);
            shuffedLetters.Text = shuffedWord;
        }


        /*
editCoin()
take the current amount of coin and put it into the ISharedPreferences
parameters: current number of coin in Integer form
return: void, the function just edit the coin in the ISharedPreference, doesn't return anything
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
        //OnBackPressed event
        //bring user back to the main activity
        public override void OnBackPressed()
        {
            base.OnBackPressed();
            Intent intent = new Intent(this, typeof(MainActivity));
            score = 0;
            result.Text = "Score: " + score;
            

            StartActivity(intent);
        }

        

                

        }
}
