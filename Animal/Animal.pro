TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt
CONFIG += c++11

SOURCES += main.cpp \
    animal.cpp \
    dog.cpp \
    cat.cpp \
    fish.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    animal.h \
    dog.h \
    cat.h \
    fish.h

