package com.example.demo;

import com.example.demo.functionality.UAccount.User;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.util.Scanner;




@SpringBootApplication
public class TwinterApplication {

	public static void main(String[] args) {
		/*
		// Pre Application things (now I'm using it for debugging):
		User user = new User("Vlad"); // User Vlad has been created
		// Checking changes of user's status
		Scanner in = new Scanner(System.in);
		INFINITY_LOOP: while(true)
		{
			user.showUserState();
			switch ((char)(in.nextLine().charAt(0)))
			{
				case 'E':
					break INFINITY_LOOP;
				case 'A':
					user.setActive();
					break;
				case 'B':
					user.setBanned();
					break;
				case 'O':
					user.setOnline();
					break;
				case 'F':
					user.setOffline();
					break;
				case 'N':
					user.setNotBanned();
					break;
				case 'I':
					user.setInactive();
					break;
			}
		}
		// something which is linked with Twint
		user.DoTwint();*/

		SpringApplication.run(TwinterApplication.class, args);

	}
}
