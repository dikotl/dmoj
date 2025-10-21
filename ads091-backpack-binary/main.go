package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	scanner := bufio.NewScanner(os.Stdin)

	var M, N int

	scanner.Scan()
	fmt.Sscanf(scanner.Text(), "%d\n", &M)

	scanner.Scan()
	fmt.Sscanf(scanner.Text(), "%d\n", &N)

	var items = make([]Item, N)
	for i := range N {
		scanner.Scan()
		fmt.Sscanf(scanner.Text(), "%d %d\n", &items[i].mass, &items[i].cost)
	}

	for _, item := range items {
		fmt.Printf("mass: %d, cost: %d\n", item.mass, item.cost)
	}
}

type Item struct {
	mass uint
	cost uint
}
