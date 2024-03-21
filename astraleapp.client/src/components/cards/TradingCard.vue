<script setup lang="ts">
import CardHeader from "./CardHeader.vue"
import CardBody from "./CardBody.vue"
import beginDrag from "./CardHandler.vue"
</script>

<template>
  <section :class="styles.CardContainer" draggable="true">
    <div :class="styles.CardLayer">
      <CardHeader />
      <CardBody />
    </div>
  </section>
</template>

<style scoped module="styles" lang="scss">
.CardBanner {
  text-orientation: sideways;
  writing-mode: vertical-rl;
  word-break: break-word;
  max-height: 32vh;
}

.CardContainer {
  position: relative;
  grid-template-rows: max-content calc(100%) calc(100%);
  overflow: scroll;
  resize: both;

  max-width: 127px;
  max-height: 254px;
  min-width: 63px;
  min-height: 127px;

  top: calc(100% / 2);
  bottom: calc(100% / 2);
  left: calc(100% / 2);
  right: calc(100% / 2);

  background-color: #0f1014;
  align-items: center;
  justify-content: center;

  cursor: move;
  scrollbar-width: none;
  -ms-overflow-style: none;
}

.CardLayer {
  clip-path: polygon(
    0 0%,
    100% 0,
    100% calc(100% - 0rem),
    calc(100% - 0rem) 100%,
    0 100%,
    0% calc(100% - 0rem)
  );

  max-width: 15vw;
  max-height: 32vh;

  padding: 0.25rem 1rem;
  margin: auto;

  opacity: 99%;

  backdrop-filter: blur(5.75256333rem);
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='4' height='4' viewBox='0 0 4 4'%3E%3Cpath fill='%234065b0' fill-opacity='0.4' d='M1 3h1v1H1V3zm2-2h1v1H3V1z'%3E%3C/path%3E%3C/svg%3E");
  background-color: #000614;

  border: none;
  box-shadow: 1rem 1rem 4.912423rem rgba(3, 2, 3, 0.1),
    -1rem 1rem 4.912423rem rgba(9, 2, 6, 0.1);
  cursor: pointer;
  color: #f7f9fe;
}
</style>
