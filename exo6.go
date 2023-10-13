package main

import "fmt"

type tuple struct {
	value     int
	iteration int
}

func mostAppear(entries []int) int {
	var values []tuple
	found := false
	for _, e := range entries {
		found = false
		for i, v := range values {
			if e == v.value {
				found = true
				values[i].iteration++
			}
		}
		if !found {
			values = append(values, tuple{e, 1})
		}
	}

	max := tuple{-1, 0}
	for _, v := range values {
		if v.iteration > max.iteration {
			max = v
		}
	}
	return max.value
}

func main() {
	fmt.Println(mostAppear([]int{0, 1, 3, 3, 3, 3, 3, 1, 0}))
	fmt.Println(mostAppear([]int{1, 2, 1, 3, 1, 4, 1, 5, 1}))
	fmt.Println(mostAppear([]int{1, 1, 1, 3, 3, 3, 1, 1, 1, 5, 5, 5, 1, 1}))
	fmt.Println(mostAppear([]int{9, 9, 9, 9, 9, 9, 9, 9, 8}))
	fmt.Println(mostAppear([]int{9, 9, 9, 9, 9, 9, 9, 9, 9}))
}
