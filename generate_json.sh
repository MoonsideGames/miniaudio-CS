#!/bin/sh
cat > tmp.c <<- EOM
#define NO_PTHREAD_IN_HEADER
#include "miniaudio.h"
EOM

./c2ffi tmp.c -I ../miniaudio -o GenerateBindings/assets/ffi.json
rm tmp.c
