Feature: Flight Bookings

Scenario: Book flight from LHE to DXB
	Given I  navigate to the "https://www.phptravels.net/home" home page
	When I select Flights
	And I enter the follwoing flight information
		| From  | To  | Depart     | Adults | Child | Infant |
		| LHE   | DXB | 2020-08-04 | 2      | 1     | 1      |
	And I select search
	Then A total of "20" listings is found
	And includes the following
		| Airline      |
		| BlueAir      |
		| Ak Bars Aero |
		| Air Burkina  |
	When I book a flight by clicking Book Now
	And  I enter the follwoing passenger ifnormation
		| Name      | Age | Passport No |
		| John Test | 55  | 1234        |
	And I select Confirm This Booking
	Then Booking Status is "Unpaid"
	When I select Pay Now
	And I select a Payment Method of "Stripe Credit Card"
	And enter the follwoing card details
		| First Name | Last Name | Card Number      | Expiration Date | Card CVV |
		| John       | Test      | 0123456789012345 | Dec 2020        | 987      |
	And I select Pay Now