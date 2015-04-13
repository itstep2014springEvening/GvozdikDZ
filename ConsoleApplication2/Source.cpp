#include <string>
#include <iostream>
#include <vector>
#include <algorithm>
#include <random>
#include <chrono>
using namespace std;
//bool Length_stroki(string i, string j) { return (i.length<j.length()); }
struct Fraction{
	int den, num;
};
ostream&operator<<(ostream&s, const Fraction &F){
	s << F.num << "/" << F.den;
	return s;
}
void main(){
	vector <string> stroki{ "Doors", "Futbol", "Robotehnica", "Pol", "X" };
	sort(stroki.begin(), stroki.end(),
		[](string i, string j){ // способ объ€вление л€мда функции
		return (i.length() < j.length());
		}
	);
	for (auto x : stroki){
		cout << x << endl;
	}
	vector<Fraction> f{ { 5, 2 }, { 4, 3 } };
	for (auto x : f){
		cout << x << endl;
	}
	//создаем массив карт
	vector <string> suits { "\003", "\004", "\005", "\006" };
	vector <string> cards { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", };
	vector <string> deck;
	for (auto suit:suits){
		for (auto card : cards){
			deck.push_back(suit + card);
		}
	}
	unsigned seed = std::chrono::system_clock::now().time_since_epoch().count();
	//shuffle(foo.begin(), foo.end(), std::default_random_engine(seed));
	shuffle(deck.begin(), deck.end(), std::default_random_engine(seed));
	int counter=0;
	for (auto tra : deck){
		if (counter == 8){
			cout << endl;
			counter = 0;
		}
		counter++;
		cout <<"\t"<< tra;
	}
	cout << endl;
	//вывести на экран слова в которых подр€д идут 3гласных

	return;
}