num1=$1
op=$2
num2=$3

case "$op" in
    "plus")
        result=$(expr $num1 + $num2)
        echo "$num1 plus $num2 is $result" ;;
esac
