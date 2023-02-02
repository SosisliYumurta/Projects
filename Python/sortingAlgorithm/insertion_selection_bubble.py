import random
import time

def generate_random_integers(num_of_integers):
    random_integers = []
    for i in range(num_of_integers):
        random_integers.append(random.randint(1, 10000))
    return random_integers


def insertion_sort(sort_list, order):
    start_time = time.time()
    for i in range(1, len(sort_list)):
        key_item = sort_list[i]
        j = i - 1
        if order == 'a':
            while j >= 0 and sort_list[j] > key_item:
                sort_list[j + 1] = sort_list[j]
                j -= 1
        elif order == 'd':
            while j >= 0 and sort_list[j] < key_item:
                sort_list[j + 1] = sort_list[j]
                j -= 1
        sort_list[j + 1] = key_item
    end_time = time.time()
    running_time = end_time - start_time
    print("The Insertion sort took {:.5f} seconds to run.".format(running_time))    
    return sort_list

def selection_sort(sort_list, order):
    start_time = time.time()
    for i in range(len(sort_list) - 1):
        min_index = i
        for j in range(i + 1, len(sort_list)):
            if order == 'a':
                if sort_list[j] < sort_list[min_index]:
                    min_index = j
            elif order == 'd':
                if sort_list[j] > sort_list[min_index]:
                    min_index = j
        sort_list[i], sort_list[min_index] = sort_list[min_index], sort_list[i]
    end_time = time.time()
    running_time = end_time - start_time
    print("The Selection sort took {:.5f} seconds to run.".format(running_time))       
    return sort_list

def bubble_sort(sort_list, order):
    start_time = time.time()
    for i in range(len(sort_list) - 1):
        for j in range(len(sort_list) - i - 1):
            if order == 'a':
                if sort_list[j] > sort_list[j + 1]:
                    sort_list[j], sort_list[j + 1] = sort_list[j + 1], sort_list[j]
            elif order == 'd':
                if sort_list[j] < sort_list[j + 1]:
                    sort_list[j], sort_list[j + 1] = sort_list[j + 1], sort_list[j]
    end_time = time.time()
    running_time = end_time - start_time
    print("The Bubble sort took {:.5f} seconds to run.".format(running_time))                 
    return sort_list



sortedList = insertion_sort(generate_random_integers(10000),'d')
print(sortedList[:10],"\n ----------------------------------------")
sortedList = selection_sort(generate_random_integers(10000),"d")
print(sortedList[:10],"\n ----------------------------------------")
sortedList = bubble_sort(generate_random_integers(10000),"d")
print(sortedList[:10],"\n ----------------------------------------")


