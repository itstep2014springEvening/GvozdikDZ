TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt
CONFIG += c++11

SOURCES += main.cpp \
    machine.cpp \
    next.cpp \
    previous.cpp \
    inc.cpp \
    dec.cpp \
    open.cpp \
    close.cpp \
    write.cpp \
    read.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    machine.h \
    term.h \
    next.h \
    previous.h \
    inc.h \
    dec.h \
    open.h \
    close.h \
    read.h \
    write.h

