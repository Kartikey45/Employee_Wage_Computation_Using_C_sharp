#!/bin/bash -x

echo "********** Welcome to Regular Expression **********"

#CHECKING VALID OR INVALID CONDITIONS
function conditionCheck()
{
	if [[ $value =~ $regexPattern ]]
	then
		echo "valid "
	else
		echo "invalid"
	fi
}

#FUNCTION OF FIRST NAME
function firstName()
{
	read -p "First name :" value
	regexPattern="^[A-Z][a-zA-Z]{2,}$"
	conditionCheck
}

#FUNCTION OF LAST NAME
function lastName()
{
	read -p "Enter Last name :" value
	regexPattern="^[A-Z]{1}[a-zA-Z]{2,}$"
	conditionCheck
}

#FUNCTION OF E-MAIL
function email()
{
	read -p "Enter Email id :" value
	regexPattern="^[a-zA-Z0-9+-]{1,}([.][a-z0-9+-]{1,})?[@]([a-zA-Z0-9]{1,}[.][a-z]{2,3})([.][a-z]{2,3})?$"
	conditionCheck
}

#FUNCTION OF VALID MOBILE NUMBER
function mobileNumber()
{
	read -p "Enter Mobile number :" value
	regexPattern="^[0-9]{2}[ ][0-9]{10}$"
	conditionCheck
}

#FUNCTIONS CALL
firstName
lastName
email
mobileNumber
