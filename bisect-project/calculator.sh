#!/usr/bin/env bash

if [ $1 = "help" ]
    then
        echo "A simple bash calcaultor providing +, -, * and / operations."
        echo "Usage: "
        echo ""
        echo "./calculator.sh <number> <operator> <number>"
        echo ""
        echo "Possible operators:"
        echo "- plus"
        echo "- minus"
        echo "- times"
        echo "- divided by"
        exit 0
fi

case "$2" in
    "plus")
        result=$(expr $1 + $3)
        echo "$1 plus $3 is $result" ;;
    "minus")
        result=$(expr $1 + $3)
        echo "$1 minus $3 is $result" ;;
    "times")
        result=$(expr $1 \* $3)
        echo "$1 times $3 is $result" ;;
    "divided")
        if [ "$3" = "by" ]
            then
                result=$(expr $1 / $4)
                echo "$1 divided by $4 is $result"
        else
            echo "When trying a division, write the full 'divided by'"
            exit 1
        fi ;;
    *)
        echo "Please use 'plus', 'minus', 'times' or 'divided by' as operator"
        exit 1
esac
