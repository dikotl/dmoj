package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

func main() {
	buf := make([]byte, 18)
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Buffer(buf, len(buf))

	root := (*Node)(nil)

	for scanner.Scan() {
		N := 0
		input := scanner.Text()

		if _, err := fmt.Sscanf(input, "ADD %d\n", &N); err == nil {
			if add(&root, N) {
				fmt.Println("DONE")
			} else {
				fmt.Println("ALREADY")
			}
		} else if _, err := fmt.Sscanf(input, "SEARCH %d\n", &N); err == nil {
			if search(root, N) {
				fmt.Println("YES")
			} else {
				fmt.Println("NO")
			}
		} else if _, err := fmt.Sscanf(input, "PRINTTREE\n"); err == nil {
			printTree(root, 0)
		} else {
			break
		}
	}
}

type Node struct {
	left  *Node
	right *Node
	data  int
}

func search(node *Node, item int) (found bool) {
	if node == nil {
		return false
	}
	if node.data == item {
		return true
	}
	return search(node.left, item) || search(node.right, item)
}

func add(node0 **Node, item int) (inserted bool) {
	if *node0 == nil {
		*node0 = &Node{data: item}
		return true
	}
	node := *node0
	if item < node.data {
		return add(&node.left, item)
	}
	if item > node.data {
		return add(&node.right, item)
	}
	return false
}

func printTree(node *Node, level int) {
	if node != nil {
		printTree(node.left, level+1)
		fmt.Printf("%s%d\n", strings.Repeat(".", level), node.data)
		printTree(node.right, level+1)
	}
}
